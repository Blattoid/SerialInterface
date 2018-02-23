using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SerialInterface
{
    public partial class MainWindow : Form
    {
        //Program name
        public static string appName = "Serial Interface";
        public MainWindow()
        {
            //runs on startup
            InitializeComponent();
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When the application closes, terminate the process.
            Environment.Exit(0);
        }

        private void serialInput_KeyDown(object sender, KeyEventArgs e)
        {
            //enter triggers a send
            if (e.KeyData == Keys.Enter)
            {
                //supress the ding sound caused by trying to put an enter in a single line textbox.
                e.SuppressKeyPress = true;

                //call the sendData void to send the string
                sendData(serialInput.Text);
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            sendData(serialInput.Text); //when the send button is pressed, send whatever is in the input box.
        }
        void sendData(string data)
        {
            //send the string to the serial port if connected.
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(serialInput.Text);

                //clear the textbox to make way for the next thing they will send.
                serialInput.Text = "";
            }
            else
            {
                MessageBox.Show("Error sending! Serial port isn't connected."); //If the serial port isn't connected and they try to send something, show this error.
            }
        }

        private void COMList_TextChanged(object sender, EventArgs e)
        {
            //disconnect from the current port if connected.
            if (serialPort.IsOpen) { serialPort.Close(); }
            //switch to the new port
            serialPort.PortName = COMList.Text;
        }
        private void COMList_DropDown(object sender, EventArgs e)
        {
            //clear the list of ports
            COMList.Items.Clear();
            //use System.IO.Ports.SerialPort.GetPortNames() to get a list of all the avaliable ports.
            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
            //for every port, add it to the list of options.
            foreach (string port in comPorts)
            {
                COMList.Items.Add(port); //add the port to the list
            }
        }

        private void COMBaud_ValueChanged(object sender, EventArgs e)
        {
            //switch to the new baud rate
            serialPort.BaudRate = Convert.ToInt32(COMBaud.Text);
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /* append the incoming line as a new line in the output box.
               for some reason, this void cannot directly access the form controls because it is apparently a thread... ¯\_(ツ)_/¯ */
            this.InvokeEx(f => serialOutput.Text = serialOutput.Text + serialPort.ReadLine());
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            //clear the output
            serialOutput.Text = "";

            //set the title to include the COM port chosen
            Text = appName + " - " + serialPort.PortName;
            //attempt to open the connection
            try { serialPort.Open(); }
            catch (Exception err)
            {
                //show why we couldnt connect
                MessageBox.Show("Error opening connection: " + err.Message);
            }
        }

        private void serialOutput_TextChanged(object sender, EventArgs e)
        {
            //when new data is written, scroll to the bottom automagically.
            serialOutput.SelectionStart = serialOutput.Text.Length;
            serialOutput.ScrollToCaret();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //create a new SettingsWindow object
            SettingsWindow settingsDialog = new SettingsWindow();
            // Show settingsDialog as a modal dialog
            settingsDialog.ShowDialog(this);

            //apply the settings to the serial port
            //stopbit objects are not strings, so we have to handle this.
            if (Properties.Settings.Default.StopBits == 0) { serialPort.StopBits = System.IO.Ports.StopBits.None; }
            else if (Properties.Settings.Default.StopBits == 1) { serialPort.StopBits = System.IO.Ports.StopBits.One; }
            else if (Properties.Settings.Default.StopBits == 1.5) { serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive; }
            else if (Properties.Settings.Default.StopBits == 2) { serialPort.StopBits = System.IO.Ports.StopBits.Two; }
            //neither are serial port parity objects.
            if (Properties.Settings.Default.Parity == "None") { serialPort.Parity = System.IO.Ports.Parity.None; }
            else if (Properties.Settings.Default.Parity == "Odd") { serialPort.Parity = System.IO.Ports.Parity.Odd; }
            else if (Properties.Settings.Default.Parity == "Even") { serialPort.Parity = System.IO.Ports.Parity.Even; }
            else if (Properties.Settings.Default.Parity == "Mark") { serialPort.Parity = System.IO.Ports.Parity.Mark; }
            else if (Properties.Settings.Default.Parity == "Space") { serialPort.Parity = System.IO.Ports.Parity.Space; }

            //the rest are very simple.
            serialPort.DataBits = Properties.Settings.Default.DataBits;
            serialPort.RtsEnable = Properties.Settings.Default.RTS;
            serialPort.DtrEnable = Properties.Settings.Default.DTR;
        }
    }
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }
    }
}
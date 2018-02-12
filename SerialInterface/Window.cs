using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
#pragma warning disable IDE1006 // Disable pesky naming style warnings (not required)

namespace SerialInterface
{
    public partial class Window : Form
    {
        public static string appName = "Serial Interface";
        public Window()
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

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /* append the incoming line as a new line in the output box.
               for some reason, this void cannot access the form controls ¯\_(ツ)_/¯ */
            this.InvokeEx(f => serialOutput.Text = serialOutput.Text + serialPort.ReadLine());
        }
        private void serialPort_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString()); //display whatever error is spat out.
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
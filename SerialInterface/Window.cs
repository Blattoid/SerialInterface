using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable IDE1006 // Disable pesky naming style warnings (not required)

namespace SerialInterface
{
    public partial class Window : Form
    {
        public Window()
        {
            //runs on startup
            InitializeComponent();

            //spawn thread for checking if we are connected to the port constantly
            Thread chkConnectivity = new Thread(checkConnectivity);
            chkConnectivity.Start();
        }

        public void updateConnectivityIndicator(string message, Color colour)
        {
            //the simplest method, in my knowledge, for updating form controls inside a thread

                connectionIndicator.ForeColor = colour;
                connectionIndicator.Text = message;

        }

        void checkConnectivity()
        {
            //10 times a second, check if the port is connected.
            Thread.Sleep(100);
            if (serialPort.IsOpen)
            {
                updateConnectivityIndicator("Status: Connected",Color.Green);
            }
            else
            {
                updateConnectivityIndicator("Status: Disconnected",Color.Red);
            }
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
            serialOutput.Text = serialOutput.Text + Environment.NewLine + serialPort.ReadLine(); //append the incoming line as a new line in the output box.
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
            //update the indicator
            updateConnectivityIndicator("Connecting...",Color.Yellow);
            //clear the output
            serialOutput.Text = "";
            //attempt to open the connection
            try { serialPort.Open(); }
            catch (Exception err) { MessageBox.Show("Error opening connection: " + err.Message); }
        }
    }
}

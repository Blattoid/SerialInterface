using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialInterface
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void serialInput_KeyDown(object sender, KeyEventArgs e)
        {
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
            sendData(serialInput.Text);
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
                MessageBox.Show("Error sending! Serial port isn't connected.");
            }
        }
    }
}

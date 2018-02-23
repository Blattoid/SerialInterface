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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            //load the valid options into the controls
            int i = 5;
            while (i <= 8) { databits.Items.Add(i); i++; }
            stopbits.Items.AddRange(new string[] { "0", "1", "1.5", "2" });
            parity.Items.AddRange(new string[] { "None", "Odd", "Even", "Mark", "Space" });

            //import the current settings and apply them to the controls to have them show the current settings
            databits.Text = Properties.Settings.Default.DataBits.ToString();
            stopbits.Text = Properties.Settings.Default.StopBits.ToString();
            parity.Text = Properties.Settings.Default.Parity;
            rts.Checked = Properties.Settings.Default.RTS;
            dtr.Checked = Properties.Settings.Default.DTR;
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            //default options
            databits.Text = "8";
            stopbits.Text = "1";
            parity.Text = "None";
            rts.Checked = false;
            dtr.Checked = false;
        }
        void apply()
        {
            //update the settings to the values of the controls
            Properties.Settings.Default.DataBits = Convert.ToInt16(databits.Text);
            Properties.Settings.Default.StopBits = Convert.ToInt16(stopbits.Text);
            Properties.Settings.Default.Parity = parity.Text;
            Properties.Settings.Default.RTS = rts.Checked;
            Properties.Settings.Default.DTR = dtr.Checked;

            //save the changes
            Properties.Settings.Default.Save();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            apply();
        }
    }
}

namespace SerialInterface
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialInput = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.COMList = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.serialOutput = new System.Windows.Forms.RichTextBox();
            this.COMBaud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.COMBaud)).BeginInit();
            this.SuspendLayout();
            // 
            // serialInput
            // 
            this.serialInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialInput.Location = new System.Drawing.Point(12, 353);
            this.serialInput.Name = "serialInput";
            this.serialInput.Size = new System.Drawing.Size(515, 26);
            this.serialInput.TabIndex = 1;
            this.serialInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialInput_KeyDown);
            // 
            // serialPort
            // 
            this.serialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort_ErrorReceived);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(533, 350);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(60, 35);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // COMList
            // 
            this.COMList.FormattingEnabled = true;
            this.COMList.Location = new System.Drawing.Point(12, 385);
            this.COMList.Name = "COMList";
            this.COMList.Size = new System.Drawing.Size(121, 28);
            this.COMList.TabIndex = 3;
            this.COMList.DropDown += new System.EventHandler(this.COMList_DropDown);
            this.COMList.TextChanged += new System.EventHandler(this.COMList_TextChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(262, 386);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(90, 33);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serialOutput
            // 
            this.serialOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialOutput.Location = new System.Drawing.Point(12, 12);
            this.serialOutput.Name = "serialOutput";
            this.serialOutput.ReadOnly = true;
            this.serialOutput.Size = new System.Drawing.Size(581, 334);
            this.serialOutput.TabIndex = 7;
            this.serialOutput.Text = "";
            this.serialOutput.TextChanged += new System.EventHandler(this.serialOutput_TextChanged);
            // 
            // COMBaud
            // 
            this.COMBaud.Location = new System.Drawing.Point(139, 386);
            this.COMBaud.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.COMBaud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.COMBaud.Name = "COMBaud";
            this.COMBaud.Size = new System.Drawing.Size(120, 26);
            this.COMBaud.TabIndex = 8;
            this.COMBaud.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 436);
            this.Controls.Add(this.COMBaud);
            this.Controls.Add(this.serialOutput);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.COMList);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.serialInput);
            this.MinimumSize = new System.Drawing.Size(370, 200);
            this.Name = "Window";
            this.Text = "Serial Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.COMBaud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox serialInput;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox COMList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RichTextBox serialOutput;
        private System.Windows.Forms.NumericUpDown COMBaud;
    }
}


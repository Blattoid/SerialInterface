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
            this.serialOutput = new System.Windows.Forms.TextBox();
            this.serialInput = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialOutput
            // 
            this.serialOutput.AcceptsReturn = true;
            this.serialOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serialOutput.Location = new System.Drawing.Point(12, 12);
            this.serialOutput.Multiline = true;
            this.serialOutput.Name = "serialOutput";
            this.serialOutput.ReadOnly = true;
            this.serialOutput.Size = new System.Drawing.Size(581, 338);
            this.serialOutput.TabIndex = 0;
            // 
            // serialInput
            // 
            this.serialInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialInput.Location = new System.Drawing.Point(12, 356);
            this.serialInput.Name = "serialInput";
            this.serialInput.Size = new System.Drawing.Size(515, 26);
            this.serialInput.TabIndex = 1;
            this.serialInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialInput_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(533, 356);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(60, 26);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 410);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.serialInput);
            this.Controls.Add(this.serialOutput);
            this.MinimumSize = new System.Drawing.Size(370, 200);
            this.Name = "Window";
            this.Text = "Serial Interface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serialOutput;
        private System.Windows.Forms.TextBox serialInput;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button sendButton;
    }
}


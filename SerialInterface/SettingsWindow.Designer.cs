namespace SerialInterface
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.bottom_table = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.databits_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.parity_label = new System.Windows.Forms.Label();
            this.databits = new System.Windows.Forms.ComboBox();
            this.stopbits = new System.Windows.Forms.ComboBox();
            this.parity = new System.Windows.Forms.ComboBox();
            this.dtr_label = new System.Windows.Forms.Label();
            this.dtr = new System.Windows.Forms.CheckBox();
            this.options_container = new System.Windows.Forms.TableLayoutPanel();
            this.rts_label = new System.Windows.Forms.Label();
            this.rts = new System.Windows.Forms.CheckBox();
            this.bottom_table.SuspendLayout();
            this.options_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottom_table
            // 
            this.bottom_table.ColumnCount = 2;
            this.bottom_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_table.Controls.Add(this.applyButton, 1, 0);
            this.bottom_table.Controls.Add(this.resetbutton, 0, 0);
            this.bottom_table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_table.Location = new System.Drawing.Point(0, 192);
            this.bottom_table.Name = "bottom_table";
            this.bottom_table.RowCount = 1;
            this.bottom_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottom_table.Size = new System.Drawing.Size(330, 51);
            this.bottom_table.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(168, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(159, 45);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetbutton.Location = new System.Drawing.Point(3, 3);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(159, 45);
            this.resetbutton.TabIndex = 0;
            this.resetbutton.Text = "Reset to defaults";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // databits_label
            // 
            this.databits_label.AutoSize = true;
            this.databits_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databits_label.Location = new System.Drawing.Point(3, 0);
            this.databits_label.Name = "databits_label";
            this.databits_label.Size = new System.Drawing.Size(146, 34);
            this.databits_label.TabIndex = 1;
            this.databits_label.Text = "Data Bits";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopbits_label.Location = new System.Drawing.Point(3, 34);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(146, 34);
            this.stopbits_label.TabIndex = 2;
            this.stopbits_label.Text = "Stop Bits";
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parity_label.Location = new System.Drawing.Point(3, 68);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(146, 34);
            this.parity_label.TabIndex = 3;
            this.parity_label.Text = "Parity";
            // 
            // databits
            // 
            this.databits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databits.FormattingEnabled = true;
            this.databits.Location = new System.Drawing.Point(155, 3);
            this.databits.Name = "databits";
            this.databits.Size = new System.Drawing.Size(146, 28);
            this.databits.TabIndex = 5;
            // 
            // stopbits
            // 
            this.stopbits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopbits.FormattingEnabled = true;
            this.stopbits.Location = new System.Drawing.Point(155, 37);
            this.stopbits.Name = "stopbits";
            this.stopbits.Size = new System.Drawing.Size(146, 28);
            this.stopbits.TabIndex = 6;
            // 
            // parity
            // 
            this.parity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parity.FormattingEnabled = true;
            this.parity.Location = new System.Drawing.Point(155, 71);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(146, 28);
            this.parity.TabIndex = 7;
            // 
            // dtr_label
            // 
            this.dtr_label.AutoSize = true;
            this.dtr_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtr_label.Location = new System.Drawing.Point(3, 129);
            this.dtr_label.Name = "dtr_label";
            this.dtr_label.Size = new System.Drawing.Size(146, 40);
            this.dtr_label.TabIndex = 9;
            this.dtr_label.Text = "DTR Enable";
            // 
            // dtr
            // 
            this.dtr.AutoSize = true;
            this.dtr.Location = new System.Drawing.Point(155, 132);
            this.dtr.Name = "dtr";
            this.dtr.Size = new System.Drawing.Size(22, 21);
            this.dtr.TabIndex = 10;
            this.dtr.UseVisualStyleBackColor = true;
            // 
            // options_container
            // 
            this.options_container.AutoSize = true;
            this.options_container.ColumnCount = 2;
            this.options_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.options_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.options_container.Controls.Add(this.dtr_label, 0, 4);
            this.options_container.Controls.Add(this.databits, 1, 0);
            this.options_container.Controls.Add(this.parity_label, 0, 2);
            this.options_container.Controls.Add(this.stopbits, 1, 1);
            this.options_container.Controls.Add(this.stopbits_label, 0, 1);
            this.options_container.Controls.Add(this.databits_label, 0, 0);
            this.options_container.Controls.Add(this.parity, 1, 2);
            this.options_container.Controls.Add(this.dtr, 1, 4);
            this.options_container.Controls.Add(this.rts_label, 0, 3);
            this.options_container.Controls.Add(this.rts, 1, 3);
            this.options_container.Location = new System.Drawing.Point(12, 12);
            this.options_container.Name = "options_container";
            this.options_container.RowCount = 5;
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.options_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.options_container.Size = new System.Drawing.Size(304, 169);
            this.options_container.TabIndex = 11;
            // 
            // rts_label
            // 
            this.rts_label.AutoSize = true;
            this.rts_label.Location = new System.Drawing.Point(3, 102);
            this.rts_label.Name = "rts_label";
            this.rts_label.Size = new System.Drawing.Size(41, 20);
            this.rts_label.TabIndex = 12;
            this.rts_label.Text = "RTS";
            // 
            // rts
            // 
            this.rts.AutoSize = true;
            this.rts.Location = new System.Drawing.Point(155, 105);
            this.rts.Name = "rts";
            this.rts.Size = new System.Drawing.Size(22, 21);
            this.rts.TabIndex = 13;
            this.rts.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 243);
            this.Controls.Add(this.options_container);
            this.Controls.Add(this.bottom_table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.bottom_table.ResumeLayout(false);
            this.options_container.ResumeLayout(false);
            this.options_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bottom_table;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label databits_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.ComboBox databits;
        private System.Windows.Forms.ComboBox stopbits;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.Label dtr_label;
        private System.Windows.Forms.CheckBox dtr;
        private System.Windows.Forms.TableLayoutPanel options_container;
        private System.Windows.Forms.Label rts_label;
        private System.Windows.Forms.CheckBox rts;
    }
}
﻿namespace AxlesView
{
    partial class Form1
    {
        /// <Summary>
        /// Required designer variable.
        /// </ Summary>
        private System.ComponentModel.IContainer components = null;

        /// <Summary>
        /// Clean up all the resources being used.
        /// </ Summary>
        /// <Param name = "disposing"> if managed resources should be released, it is true; otherwise, false. </ Param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <Summary>
        /// Required method for Designer support - do not
        /// Using the code editor to modify the contents of this method.
        /// </ Summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yaw_label = new System.Windows.Forms.Label();
            this.pit_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.row_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.axles3D1 = new AxlesGL.Axles3D();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbhexshow = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.throttle = new System.Windows.Forms.TrackBar();
            this.Motor4 = new System.Windows.Forms.ProgressBar();
            this.Motor3 = new System.Windows.Forms.ProgressBar();
            this.Motor2 = new System.Windows.Forms.ProgressBar();
            this.Motor1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).BeginInit();
            this.SuspendLayout();
            //
            // GroupBox1
            //
            this.groupBox1.Controls.Add(this.yaw_label);
            this.groupBox1.Controls.Add(this.pit_label);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.row_label);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.axles3D1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3D pose";
            //
            // Yaw_label
            //
            this.yaw_label.AutoSize = true;
            this.yaw_label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yaw_label.ForeColor = System.Drawing.Color.Lime;
            this.yaw_label.Location = new System.Drawing.Point(334, 129);
            this.yaw_label.Name = "yaw_label";
            this.yaw_label.Size = new System.Drawing.Size(17, 16);
            this.yaw_label.TabIndex = 8;
            this.yaw_label.Text = "0";
            //
            // Pit_label
            //
            this.pit_label.AutoSize = true;
            this.pit_label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pit_label.ForeColor = System.Drawing.Color.Blue;
            this.pit_label.Location = new System.Drawing.Point(335, 78);
            this.pit_label.Name = "pit_label";
            this.pit_label.Size = new System.Drawing.Size(17, 16);
            this.pit_label.TabIndex = 7;
            this.pit_label.Text = "0";
            //
            // Label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Yaw:";
            //
            // Label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(333, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Roll:";
            //
            // Row_label
            //
            this.row_label.AutoSize = true;
            this.row_label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.row_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.row_label.Location = new System.Drawing.Point(335, 30);
            this.row_label.Name = "row_label";
            this.row_label.Size = new System.Drawing.Size(17, 16);
            this.row_label.TabIndex = 4;
            this.row_label.Text = "0";
            //
            // Label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Pitch:";
            //
            // Axles3D1
            //
            this.axles3D1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.axles3D1.AngleX = 0D;
            this.axles3D1.AngleY = 0D;
            this.axles3D1.AngleZ = 0D;
            this.axles3D1.Azimuth = 0D;
            this.axles3D1.BackColor = System.Drawing.Color.Black;
            this.axles3D1.Elevation = 0D;
            this.axles3D1.Location = new System.Drawing.Point(5, 14);
            this.axles3D1.Name = "axles3D1";
            this.axles3D1.Size = new System.Drawing.Size(325, 320);
            this.axles3D1.TabIndex = 2;
            this.axles3D1.VSync = false;
            this.axles3D1.Load += new System.EventHandler(this.axles3D1_Load);
            //
            // GroupBox2
            //
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.gbPortSettings);
            this.groupBox2.Controls.Add(this.btnOpenPort);
            this.groupBox2.Controls.Add(this.gbMode);
            this.groupBox2.Controls.Add(this.rtfTerminal);
            this.groupBox2.Controls.Add(this.lblSend);
            this.groupBox2.Controls.Add(this.txtSendData);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(393, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 551);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Output";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            //
            // Button3
            //
            this.button3.Location = new System.Drawing.Point(455, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 24);
            this.button3.TabIndex = 23;
            this.button3.Text = "Clear screen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // GbPortSettings
            //
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Location = new System.Drawing.Point(8, 470);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(307, 81);
            this.gbPortSettings.TabIndex = 19;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Serial port settings";
            //
            // LblComPort
            //
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 18);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(37, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "Port Number:";
            //
            // CmbPortName
            //
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
"COM1",
"COM2",
"COM3",
"COM4",
"COM5",
"COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(14, 34);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 21);
            this.cmbPortName.TabIndex = 1;
            //
            // CmbBaudRate
            //
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
"300",
"600",
"1200",
"2400",
"4800",
"9600",
"14400",
"28800",
"36,000",
"115000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(87, 35);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(61, 21);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Text = "115200";
            this.cmbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cmbBaudRate_SelectedIndexChanged);
            //
            // LblBaudRate
            //
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(85, 15);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(37, 13);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            //
            // LblDataBits
            //
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(241, 17);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(37, 13);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "data bits:";
            //
            // CmbParity
            //
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
"None",
"Even",
"Odd"});
            this.cmbParity.Location = new System.Drawing.Point(166, 36);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(60, 21);
            this.cmbParity.TabIndex = 5;
            //
            // CmbDataBits
            //
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
"7",
"8",
"9"});
            this.cmbDataBits.Location = new System.Drawing.Point(243, 37);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(48, 21);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.SelectedIndexChanged += new System.EventHandler(this.cmbDataBits_SelectedIndexChanged);
            //
            // Label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parity:";
            //
            // BtnOpenPort
            //
            this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPort.Location = new System.Drawing.Point(433, 480);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 65);
            this.btnOpenPort.TabIndex = 21;
            this.btnOpenPort.Text = "connected aircraft";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click_1);
            //
            // GbMode
            //
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.Controls.Add(this.rbhexshow);
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(321, 470);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(106, 77);
            this.gbMode.TabIndex = 20;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            //
            // Rbhexshow
            //
            this.rbhexshow.AutoSize = true;
            this.rbhexshow.Location = new System.Drawing.Point(9, 35);
            this.rbhexshow.Name = "rbhexshow";
            this.rbhexshow.Size = new System.Drawing.Size(58, 17);
            this.rbhexshow.TabIndex = 2;
            this.rbhexshow.Text = "16 hex";
            //
            // RbText
            //
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(9, 54);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(43, 17);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            //
            // RbHex
            //
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(9, 16);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(67, 17);
            this.rbHex.TabIndex = 1;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "display attitude";
            //
            // RtfTerminal
            //
            this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.rtfTerminal.Location = new System.Drawing.Point(8, 14);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(498, 423);
            this.rtfTerminal.TabIndex = 15;
            this.rtfTerminal.Text = "";
            this.rtfTerminal.TextChanged += new System.EventHandler(this.rtfTerminal_TextChanged_1);
            //
            // LblSend
            //
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(10, 449);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(46, 13);
            this.lblSend.TabIndex = 16;
            this.lblSend.Text = "Send Data";
            //
            // TxtSendData
            //
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(66, 444);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(333, 20);
            this.txtSendData.TabIndex = 17;
            this.txtSendData.TextChanged += new System.EventHandler(this.txtSendData_TextChanged);
            //
            // BtnSend
            //
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(401, 444);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(52, 24);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            //
            // GroupBox3
            //
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.throttle);
            this.groupBox3.Controls.Add(this.Motor4);
            this.groupBox3.Controls.Add(this.Motor3);
            this.groupBox3.Controls.Add(this.Motor2);
            this.groupBox3.Controls.Add(this.Motor1);
            this.groupBox3.Location = new System.Drawing.Point(7, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 205);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Throttle display";
            //
            // Label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "motor 3:";
            //
            // Label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motor 1:";
            //
            // Label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motor 4:";
            //
            // Label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motor 2:";
            //
            // Label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accelerator operation:";
            //
            // Throttle
            //
            this.throttle.Location = new System.Drawing.Point(156, 21);
            this.throttle.Maximum = 100;
            this.throttle.Name = "throttle";
            this.throttle.Size = new System.Drawing.Size(214, 45);
            this.throttle.TabIndex = 4;
            this.throttle.Scroll += new System.EventHandler(this.throttle_Scroll);
            //
            // Motor4
            //
            this.Motor4.Location = new System.Drawing.Point(237, 141);
            this.Motor4.Name = "Motor4";
            this.Motor4.Size = new System.Drawing.Size(133, 53);
            this.Motor4.TabIndex = 3;
            this.Motor4.Value = 20;
            //
            // Motor3
            //
            this.Motor3.Location = new System.Drawing.Point(50, 141);
            this.Motor3.Name = "Motor3";
            this.Motor3.Size = new System.Drawing.Size(133, 53);
            this.Motor3.TabIndex = 2;
            this.Motor3.Value = 20;
            //
            // Motor2
            //
            this.Motor2.Location = new System.Drawing.Point(237, 72);
            this.Motor2.Name = "Motor2";
            this.Motor2.Size = new System.Drawing.Size(133, 53);
            this.Motor2.TabIndex = 1;
            this.Motor2.Value = 20;
            //
            // Motor1
            //
            this.Motor1.Location = new System.Drawing.Point(48, 72);
            this.Motor1.Name = "Motor1";
            this.Motor1.Size = new System.Drawing.Size(133, 53);
            this.Motor1.TabIndex = 0;
            this.Motor1.Value = 20;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 559);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CrazePony PC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxlesGL.Axles3D axles3D1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar Motor4;
        private System.Windows.Forms.ProgressBar Motor3;
        private System.Windows.Forms.ProgressBar Motor2;
        private System.Windows.Forms.ProgressBar Motor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar throttle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label row_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label yaw_label;
        private System.Windows.Forms.Label pit_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbhexshow;
        private System.Windows.Forms.Button button3;



    }
}


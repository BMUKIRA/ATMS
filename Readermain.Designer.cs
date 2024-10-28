namespace CRT284U
{
    partial class Readermain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MagReadBtn = new System.Windows.Forms.Button();
            this.Track3DataTxt = new System.Windows.Forms.TextBox();
            this.Track2DataTxt = new System.Windows.Forms.TextBox();
            this.Track1DataTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CPUWarmResetBtn = new System.Windows.Forms.Button();
            this.CPUColdResetBtn = new System.Windows.Forms.Button();
            this.CPUAPDUCOMMAND = new System.Windows.Forms.ComboBox();
            this.CpuBackText = new System.Windows.Forms.TextBox();
            this.CPUResetText = new System.Windows.Forms.TextBox();
            this.SendAPDUbtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CPUDownbtn = new System.Windows.Forms.Button();
            this.IRStatus = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CloseCommBtn = new System.Windows.Forms.Button();
            this.OpenCommBtn = new System.Windows.Forms.Button();
            this.ICTestTypeBtn = new System.Windows.Forms.Button();
            this.CommPortStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPUModeOption2 = new System.Windows.Forms.RadioButton();
            this.CPUModeOption1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CPUModeOption4 = new System.Windows.Forms.RadioButton();
            this.CPUModeOption3 = new System.Windows.Forms.RadioButton();
            this.ClearBufferBtn = new System.Windows.Forms.Button();
            this.ReadTrack1 = new System.Windows.Forms.CheckBox();
            this.ReadTrack2 = new System.Windows.Forms.CheckBox();
            this.ReadTrack3 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 400);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReadTrack3);
            this.tabPage1.Controls.Add(this.ReadTrack2);
            this.tabPage1.Controls.Add(this.ReadTrack1);
            this.tabPage1.Controls.Add(this.ClearBufferBtn);
            this.tabPage1.Controls.Add(this.MagReadBtn);
            this.tabPage1.Controls.Add(this.Track3DataTxt);
            this.tabPage1.Controls.Add(this.Track2DataTxt);
            this.tabPage1.Controls.Add(this.Track1DataTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mag-Card";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MagReadBtn
            // 
            this.MagReadBtn.Location = new System.Drawing.Point(208, 279);
            this.MagReadBtn.Name = "MagReadBtn";
            this.MagReadBtn.Size = new System.Drawing.Size(112, 40);
            this.MagReadBtn.TabIndex = 40;
            this.MagReadBtn.Text = "Mag-Card Read";
            this.MagReadBtn.UseVisualStyleBackColor = true;
            this.MagReadBtn.Click += new System.EventHandler(this.MagReadBtn_Click);
            // 
            // Track3DataTxt
            // 
            this.Track3DataTxt.Location = new System.Drawing.Point(152, 203);
            this.Track3DataTxt.Multiline = true;
            this.Track3DataTxt.Name = "Track3DataTxt";
            this.Track3DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track3DataTxt.TabIndex = 39;
            // 
            // Track2DataTxt
            // 
            this.Track2DataTxt.Location = new System.Drawing.Point(152, 133);
            this.Track2DataTxt.Multiline = true;
            this.Track2DataTxt.Name = "Track2DataTxt";
            this.Track2DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track2DataTxt.TabIndex = 37;
            // 
            // Track1DataTxt
            // 
            this.Track1DataTxt.Location = new System.Drawing.Point(152, 63);
            this.Track1DataTxt.Multiline = true;
            this.Track1DataTxt.Name = "Track1DataTxt";
            this.Track1DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track1DataTxt.TabIndex = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.CPUWarmResetBtn);
            this.tabPage2.Controls.Add(this.CPUColdResetBtn);
            this.tabPage2.Controls.Add(this.CPUAPDUCOMMAND);
            this.tabPage2.Controls.Add(this.CpuBackText);
            this.tabPage2.Controls.Add(this.CPUResetText);
            this.tabPage2.Controls.Add(this.SendAPDUbtn);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.CPUDownbtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU Card";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CPUWarmResetBtn
            // 
            this.CPUWarmResetBtn.Location = new System.Drawing.Point(142, 279);
            this.CPUWarmResetBtn.Name = "CPUWarmResetBtn";
            this.CPUWarmResetBtn.Size = new System.Drawing.Size(114, 40);
            this.CPUWarmResetBtn.TabIndex = 85;
            this.CPUWarmResetBtn.Text = "Warm Reset";
            this.CPUWarmResetBtn.UseVisualStyleBackColor = true;
            this.CPUWarmResetBtn.Click += new System.EventHandler(this.CPUWarmResetBtn_Click);
            // 
            // CPUColdResetBtn
            // 
            this.CPUColdResetBtn.Location = new System.Drawing.Point(142, 233);
            this.CPUColdResetBtn.Name = "CPUColdResetBtn";
            this.CPUColdResetBtn.Size = new System.Drawing.Size(114, 40);
            this.CPUColdResetBtn.TabIndex = 84;
            this.CPUColdResetBtn.Text = "Cold Reset";
            this.CPUColdResetBtn.UseVisualStyleBackColor = true;
            this.CPUColdResetBtn.Click += new System.EventHandler(this.CPUColdResetBtn_Click);
            // 
            // CPUAPDUCOMMAND
            // 
            this.CPUAPDUCOMMAND.FormattingEnabled = true;
            this.CPUAPDUCOMMAND.Items.AddRange(new object[] {
            "0084000008",
            "00A40000023F00",
            "00A404000E315041592E5359532E4444463031"});
            this.CPUAPDUCOMMAND.Location = new System.Drawing.Point(233, 77);
            this.CPUAPDUCOMMAND.Name = "CPUAPDUCOMMAND";
            this.CPUAPDUCOMMAND.Size = new System.Drawing.Size(532, 20);
            this.CPUAPDUCOMMAND.TabIndex = 83;
            this.CPUAPDUCOMMAND.Text = "0084000008";
            // 
            // CpuBackText
            // 
            this.CpuBackText.Location = new System.Drawing.Point(233, 122);
            this.CpuBackText.Name = "CpuBackText";
            this.CpuBackText.Size = new System.Drawing.Size(533, 21);
            this.CpuBackText.TabIndex = 82;
            // 
            // CPUResetText
            // 
            this.CPUResetText.Location = new System.Drawing.Point(233, 35);
            this.CPUResetText.Name = "CPUResetText";
            this.CPUResetText.Size = new System.Drawing.Size(533, 21);
            this.CPUResetText.TabIndex = 81;
            // 
            // SendAPDUbtn
            // 
            this.SendAPDUbtn.Location = new System.Drawing.Point(315, 233);
            this.SendAPDUbtn.Name = "SendAPDUbtn";
            this.SendAPDUbtn.Size = new System.Drawing.Size(112, 40);
            this.SendAPDUbtn.TabIndex = 76;
            this.SendAPDUbtn.Text = "Send APDU";
            this.SendAPDUbtn.UseVisualStyleBackColor = true;
            this.SendAPDUbtn.Click += new System.EventHandler(this.SendAPDUbtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 80;
            this.label14.Text = "Returned Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 79;
            this.label13.Text = "Send Command";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 78;
            this.label12.Text = "ATR Information";
            // 
            // CPUDownbtn
            // 
            this.CPUDownbtn.Location = new System.Drawing.Point(503, 233);
            this.CPUDownbtn.Name = "CPUDownbtn";
            this.CPUDownbtn.Size = new System.Drawing.Size(112, 40);
            this.CPUDownbtn.TabIndex = 77;
            this.CPUDownbtn.Text = "Power Off";
            this.CPUDownbtn.UseVisualStyleBackColor = true;
            this.CPUDownbtn.Click += new System.EventHandler(this.CPUDownbtn_Click);
            // 
            // IRStatus
            // 
            this.IRStatus.Location = new System.Drawing.Point(569, 77);
            this.IRStatus.Name = "IRStatus";
            this.IRStatus.Size = new System.Drawing.Size(140, 40);
            this.IRStatus.TabIndex = 60;
            this.IRStatus.Text = "Status";
            this.IRStatus.UseVisualStyleBackColor = true;
            this.IRStatus.Click += new System.EventHandler(this.IRStatus_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(394, 77);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(140, 40);
            this.ResetBtn.TabIndex = 59;
            this.ResetBtn.Text = "INITIALIZE";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CloseCommBtn
            // 
            this.CloseCommBtn.Location = new System.Drawing.Point(219, 77);
            this.CloseCommBtn.Name = "CloseCommBtn";
            this.CloseCommBtn.Size = new System.Drawing.Size(140, 40);
            this.CloseCommBtn.TabIndex = 58;
            this.CloseCommBtn.Text = "Disconnect Device";
            this.CloseCommBtn.UseVisualStyleBackColor = true;
            this.CloseCommBtn.Click += new System.EventHandler(this.CloseCommBtn_Click);
            // 
            // OpenCommBtn
            // 
            this.OpenCommBtn.Location = new System.Drawing.Point(44, 77);
            this.OpenCommBtn.Name = "OpenCommBtn";
            this.OpenCommBtn.Size = new System.Drawing.Size(140, 40);
            this.OpenCommBtn.TabIndex = 57;
            this.OpenCommBtn.Text = "Connect Device";
            this.OpenCommBtn.UseVisualStyleBackColor = true;
            this.OpenCommBtn.Click += new System.EventHandler(this.OpenCommBtn_Click);
            // 
            // ICTestTypeBtn
            // 
            this.ICTestTypeBtn.Location = new System.Drawing.Point(744, 77);
            this.ICTestTypeBtn.Name = "ICTestTypeBtn";
            this.ICTestTypeBtn.Size = new System.Drawing.Size(140, 40);
            this.ICTestTypeBtn.TabIndex = 84;
            this.ICTestTypeBtn.Text = "IC Card Type";
            this.ICTestTypeBtn.UseVisualStyleBackColor = true;
            this.ICTestTypeBtn.Click += new System.EventHandler(this.ICTestTypeBtn_Click);
            // 
            // CommPortStatusLabel
            // 
            this.CommPortStatusLabel.AutoSize = true;
            this.CommPortStatusLabel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommPortStatusLabel.Location = new System.Drawing.Point(289, 24);
            this.CommPortStatusLabel.Name = "CommPortStatusLabel";
            this.CommPortStatusLabel.Size = new System.Drawing.Size(383, 33);
            this.CommPortStatusLabel.TabIndex = 87;
            this.CommPortStatusLabel.Text = "Device is not connected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CPUModeOption2);
            this.groupBox1.Controls.Add(this.CPUModeOption1);
            this.groupBox1.Location = new System.Drawing.Point(118, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 54);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cold Reset Option";
            // 
            // CPUModeOption2
            // 
            this.CPUModeOption2.AutoSize = true;
            this.CPUModeOption2.Location = new System.Drawing.Point(177, 24);
            this.CPUModeOption2.Name = "CPUModeOption2";
            this.CPUModeOption2.Size = new System.Drawing.Size(95, 16);
            this.CPUModeOption2.TabIndex = 89;
            this.CPUModeOption2.Text = "ISO7816 Mode";
            this.CPUModeOption2.UseVisualStyleBackColor = true;
            // 
            // CPUModeOption1
            // 
            this.CPUModeOption1.AutoSize = true;
            this.CPUModeOption1.Checked = true;
            this.CPUModeOption1.Location = new System.Drawing.Point(28, 24);
            this.CPUModeOption1.Name = "CPUModeOption1";
            this.CPUModeOption1.Size = new System.Drawing.Size(71, 16);
            this.CPUModeOption1.TabIndex = 88;
            this.CPUModeOption1.TabStop = true;
            this.CPUModeOption1.Text = "EMV Mode";
            this.CPUModeOption1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CPUModeOption4);
            this.groupBox2.Controls.Add(this.CPUModeOption3);
            this.groupBox2.Location = new System.Drawing.Point(434, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 54);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send APDU Option";
            // 
            // CPUModeOption4
            // 
            this.CPUModeOption4.AutoSize = true;
            this.CPUModeOption4.Location = new System.Drawing.Point(219, 24);
            this.CPUModeOption4.Name = "CPUModeOption4";
            this.CPUModeOption4.Size = new System.Drawing.Size(41, 16);
            this.CPUModeOption4.TabIndex = 91;
            this.CPUModeOption4.Text = "T=1";
            this.CPUModeOption4.UseVisualStyleBackColor = true;
            // 
            // CPUModeOption3
            // 
            this.CPUModeOption3.AutoSize = true;
            this.CPUModeOption3.Checked = true;
            this.CPUModeOption3.Location = new System.Drawing.Point(69, 24);
            this.CPUModeOption3.Name = "CPUModeOption3";
            this.CPUModeOption3.Size = new System.Drawing.Size(41, 16);
            this.CPUModeOption3.TabIndex = 90;
            this.CPUModeOption3.TabStop = true;
            this.CPUModeOption3.Text = "T=0";
            this.CPUModeOption3.UseVisualStyleBackColor = true;
            // 
            // ClearBufferBtn
            // 
            this.ClearBufferBtn.Location = new System.Drawing.Point(472, 279);
            this.ClearBufferBtn.Name = "ClearBufferBtn";
            this.ClearBufferBtn.Size = new System.Drawing.Size(112, 40);
            this.ClearBufferBtn.TabIndex = 41;
            this.ClearBufferBtn.Text = "Clear Buffer";
            this.ClearBufferBtn.UseVisualStyleBackColor = true;
            this.ClearBufferBtn.Click += new System.EventHandler(this.ClearBufferBtn_Click);
            // 
            // ReadTrack1
            // 
            this.ReadTrack1.AutoSize = true;
            this.ReadTrack1.Checked = true;
            this.ReadTrack1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadTrack1.Location = new System.Drawing.Point(50, 74);
            this.ReadTrack1.Name = "ReadTrack1";
            this.ReadTrack1.Size = new System.Drawing.Size(96, 16);
            this.ReadTrack1.TabIndex = 42;
            this.ReadTrack1.Text = "Read Track 1";
            this.ReadTrack1.UseVisualStyleBackColor = true;
            // 
            // ReadTrack2
            // 
            this.ReadTrack2.AutoSize = true;
            this.ReadTrack2.Checked = true;
            this.ReadTrack2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadTrack2.Location = new System.Drawing.Point(50, 146);
            this.ReadTrack2.Name = "ReadTrack2";
            this.ReadTrack2.Size = new System.Drawing.Size(96, 16);
            this.ReadTrack2.TabIndex = 43;
            this.ReadTrack2.Text = "Read Track 2";
            this.ReadTrack2.UseVisualStyleBackColor = true;
            // 
            // ReadTrack3
            // 
            this.ReadTrack3.AutoSize = true;
            this.ReadTrack3.Checked = true;
            this.ReadTrack3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadTrack3.Location = new System.Drawing.Point(50, 215);
            this.ReadTrack3.Name = "ReadTrack3";
            this.ReadTrack3.Size = new System.Drawing.Size(96, 16);
            this.ReadTrack3.TabIndex = 44;
            this.ReadTrack3.Text = "Read Track 3";
            this.ReadTrack3.UseVisualStyleBackColor = true;
            // 
            // Readermain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 578);
            this.Controls.Add(this.CommPortStatusLabel);
            this.Controls.Add(this.ICTestTypeBtn);
            this.Controls.Add(this.IRStatus);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CloseCommBtn);
            this.Controls.Add(this.OpenCommBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Readermain";
            this.Text = "CRT-284U TEST DLL";
            this.Load += new System.EventHandler(this.Readermain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button MagReadBtn;
        private System.Windows.Forms.TextBox Track3DataTxt;
        private System.Windows.Forms.TextBox Track2DataTxt;
        private System.Windows.Forms.TextBox Track1DataTxt;
        private System.Windows.Forms.Button IRStatus;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CloseCommBtn;
        private System.Windows.Forms.Button OpenCommBtn;
        private System.Windows.Forms.Button CPUWarmResetBtn;
        private System.Windows.Forms.Button CPUColdResetBtn;
        private System.Windows.Forms.ComboBox CPUAPDUCOMMAND;
        private System.Windows.Forms.TextBox CpuBackText;
        private System.Windows.Forms.TextBox CPUResetText;
        private System.Windows.Forms.Button SendAPDUbtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CPUDownbtn;
        private System.Windows.Forms.Button ICTestTypeBtn;
        private System.Windows.Forms.Label CommPortStatusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CPUModeOption4;
        private System.Windows.Forms.RadioButton CPUModeOption3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CPUModeOption2;
        private System.Windows.Forms.RadioButton CPUModeOption1;
        private System.Windows.Forms.Button ClearBufferBtn;
        private System.Windows.Forms.CheckBox ReadTrack1;
        private System.Windows.Forms.CheckBox ReadTrack3;
        private System.Windows.Forms.CheckBox ReadTrack2;
    }
}


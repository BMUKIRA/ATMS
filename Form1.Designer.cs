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
            this.label11 = new System.Windows.Forms.Label();
            this.Track2DataTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Track1DataTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CPUModeOption2 = new System.Windows.Forms.RadioButton();
            this.CPUModeOption1 = new System.Windows.Forms.RadioButton();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.MagReadBtn);
            this.tabPage1.Controls.Add(this.Track3DataTxt);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Track2DataTxt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Track1DataTxt);
            this.tabPage1.Controls.Add(this.label9);
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
            this.MagReadBtn.Location = new System.Drawing.Point(384, 279);
            this.MagReadBtn.Name = "MagReadBtn";
            this.MagReadBtn.Size = new System.Drawing.Size(112, 40);
            this.MagReadBtn.TabIndex = 40;
            this.MagReadBtn.Text = "Mag-Card Read";
            this.MagReadBtn.UseVisualStyleBackColor = true;
            // 
            // Track3DataTxt
            // 
            this.Track3DataTxt.Location = new System.Drawing.Point(152, 203);
            this.Track3DataTxt.Multiline = true;
            this.Track3DataTxt.Name = "Track3DataTxt";
            this.Track3DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track3DataTxt.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "Track 3";
            // 
            // Track2DataTxt
            // 
            this.Track2DataTxt.Location = new System.Drawing.Point(152, 133);
            this.Track2DataTxt.Multiline = true;
            this.Track2DataTxt.Name = "Track2DataTxt";
            this.Track2DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track2DataTxt.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "Track 2";
            // 
            // Track1DataTxt
            // 
            this.Track1DataTxt.Location = new System.Drawing.Point(152, 63);
            this.Track1DataTxt.Multiline = true;
            this.Track1DataTxt.Name = "Track1DataTxt";
            this.Track1DataTxt.Size = new System.Drawing.Size(533, 45);
            this.Track1DataTxt.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "Track 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CPUModeOption2);
            this.tabPage2.Controls.Add(this.CPUModeOption1);
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
            // CPUModeOption2
            // 
            this.CPUModeOption2.AutoSize = true;
            this.CPUModeOption2.Location = new System.Drawing.Point(423, 50);
            this.CPUModeOption2.Name = "CPUModeOption2";
            this.CPUModeOption2.Size = new System.Drawing.Size(95, 16);
            this.CPUModeOption2.TabIndex = 87;
            this.CPUModeOption2.Text = "ISO7816 Mode";
            this.CPUModeOption2.UseVisualStyleBackColor = true;
            // 
            // CPUModeOption1
            // 
            this.CPUModeOption1.AutoSize = true;
            this.CPUModeOption1.Checked = true;
            this.CPUModeOption1.Location = new System.Drawing.Point(273, 50);
            this.CPUModeOption1.Name = "CPUModeOption1";
            this.CPUModeOption1.Size = new System.Drawing.Size(71, 16);
            this.CPUModeOption1.TabIndex = 86;
            this.CPUModeOption1.TabStop = true;
            this.CPUModeOption1.Text = "EMV Mode";
            this.CPUModeOption1.UseVisualStyleBackColor = true;
            // 
            // CPUWarmResetBtn
            // 
            this.CPUWarmResetBtn.Location = new System.Drawing.Point(101, 86);
            this.CPUWarmResetBtn.Name = "CPUWarmResetBtn";
            this.CPUWarmResetBtn.Size = new System.Drawing.Size(114, 40);
            this.CPUWarmResetBtn.TabIndex = 85;
            this.CPUWarmResetBtn.Text = "Warm Reset";
            this.CPUWarmResetBtn.UseVisualStyleBackColor = true;
            // 
            // CPUColdResetBtn
            // 
            this.CPUColdResetBtn.Location = new System.Drawing.Point(103, 26);
            this.CPUColdResetBtn.Name = "CPUColdResetBtn";
            this.CPUColdResetBtn.Size = new System.Drawing.Size(114, 40);
            this.CPUColdResetBtn.TabIndex = 84;
            this.CPUColdResetBtn.Text = "Cold Reset";
            this.CPUColdResetBtn.UseVisualStyleBackColor = true;
            // 
            // CPUAPDUCOMMAND
            // 
            this.CPUAPDUCOMMAND.FormattingEnabled = true;
            this.CPUAPDUCOMMAND.Items.AddRange(new object[] {
            "0084000008",
            "00A40000023F00",
            "00A404000E315041592E5359532E4444463031"});
            this.CPUAPDUCOMMAND.Location = new System.Drawing.Point(233, 230);
            this.CPUAPDUCOMMAND.Name = "CPUAPDUCOMMAND";
            this.CPUAPDUCOMMAND.Size = new System.Drawing.Size(532, 20);
            this.CPUAPDUCOMMAND.TabIndex = 83;
            this.CPUAPDUCOMMAND.Text = "0084000008";
            // 
            // CpuBackText
            // 
            this.CpuBackText.Location = new System.Drawing.Point(233, 275);
            this.CpuBackText.Name = "CpuBackText";
            this.CpuBackText.Size = new System.Drawing.Size(533, 21);
            this.CpuBackText.TabIndex = 82;
            // 
            // CPUResetText
            // 
            this.CPUResetText.Location = new System.Drawing.Point(233, 147);
            this.CPUResetText.Name = "CPUResetText";
            this.CPUResetText.Size = new System.Drawing.Size(533, 21);
            this.CPUResetText.TabIndex = 81;
            // 
            // SendAPDUbtn
            // 
            this.SendAPDUbtn.Location = new System.Drawing.Point(103, 176);
            this.SendAPDUbtn.Name = "SendAPDUbtn";
            this.SendAPDUbtn.Size = new System.Drawing.Size(112, 40);
            this.SendAPDUbtn.TabIndex = 76;
            this.SendAPDUbtn.Text = "Send APDU";
            this.SendAPDUbtn.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 80;
            this.label14.Text = "Returned Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 79;
            this.label13.Text = "Send Command";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 78;
            this.label12.Text = "ATR Information";
            // 
            // CPUDownbtn
            // 
            this.CPUDownbtn.Location = new System.Drawing.Point(101, 308);
            this.CPUDownbtn.Name = "CPUDownbtn";
            this.CPUDownbtn.Size = new System.Drawing.Size(112, 40);
            this.CPUDownbtn.TabIndex = 77;
            this.CPUDownbtn.Text = "Power Off";
            this.CPUDownbtn.UseVisualStyleBackColor = true;
            // 
            // IRStatus
            // 
            this.IRStatus.Location = new System.Drawing.Point(463, 54);
            this.IRStatus.Name = "IRStatus";
            this.IRStatus.Size = new System.Drawing.Size(114, 40);
            this.IRStatus.TabIndex = 60;
            this.IRStatus.Text = "Status";
            this.IRStatus.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(343, 54);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(114, 40);
            this.ResetBtn.TabIndex = 59;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // CloseCommBtn
            // 
            this.CloseCommBtn.Location = new System.Drawing.Point(225, 54);
            this.CloseCommBtn.Name = "CloseCommBtn";
            this.CloseCommBtn.Size = new System.Drawing.Size(112, 40);
            this.CloseCommBtn.TabIndex = 58;
            this.CloseCommBtn.Text = "Close Comm";
            this.CloseCommBtn.UseVisualStyleBackColor = true;
            // 
            // OpenCommBtn
            // 
            this.OpenCommBtn.Location = new System.Drawing.Point(105, 54);
            this.OpenCommBtn.Name = "OpenCommBtn";
            this.OpenCommBtn.Size = new System.Drawing.Size(114, 40);
            this.OpenCommBtn.TabIndex = 57;
            this.OpenCommBtn.Text = "Open Comm";
            this.OpenCommBtn.UseVisualStyleBackColor = true;
            this.OpenCommBtn.Click += new System.EventHandler(this.OpenCommBtn_Click);
            // 
            // ICTestTypeBtn
            // 
            this.ICTestTypeBtn.Location = new System.Drawing.Point(583, 54);
            this.ICTestTypeBtn.Name = "ICTestTypeBtn";
            this.ICTestTypeBtn.Size = new System.Drawing.Size(144, 40);
            this.ICTestTypeBtn.TabIndex = 84;
            this.ICTestTypeBtn.Text = "IC Card Type";
            this.ICTestTypeBtn.UseVisualStyleBackColor = true;
            // 
            // Readermain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 578);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button MagReadBtn;
        private System.Windows.Forms.TextBox Track3DataTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Track2DataTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Track1DataTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button IRStatus;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CloseCommBtn;
        private System.Windows.Forms.Button OpenCommBtn;
        private System.Windows.Forms.RadioButton CPUModeOption2;
        private System.Windows.Forms.RadioButton CPUModeOption1;
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
    }
}


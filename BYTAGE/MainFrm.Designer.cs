namespace BYTAGE
{
    partial class MainFrm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.targetGB = new System.Windows.Forms.GroupBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.targetTB = new System.Windows.Forms.TextBox();
            this.dllGB = new System.Windows.Forms.GroupBox();
            this.btnReplacement = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.replacementTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originalTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsGB = new System.Windows.Forms.GroupBox();
            this.AdelayUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BdelayUD = new System.Windows.Forms.NumericUpDown();
            this.actionGB = new System.Windows.Forms.GroupBox();
            this.btnReplaceOnly = new System.Windows.Forms.Button();
            this.btnNoBypass = new System.Windows.Forms.Button();
            this.btnBypass = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.hashcheckerbpGB = new System.Windows.Forms.GroupBox();
            this.processhackerGB = new System.Windows.Forms.GroupBox();
            this.PHstatusGB = new System.Windows.Forms.GroupBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.adminLBL = new System.Windows.Forms.Label();
            this.statusLBL = new System.Windows.Forms.Label();
            this.pidLBL = new System.Windows.Forms.Label();
            this.PHinfoGB = new System.Windows.Forms.GroupBox();
            this.memusgLBL = new System.Windows.Forms.Label();
            this.threadsLBL = new System.Windows.Forms.Label();
            this.mwtitleLBL = new System.Windows.Forms.Label();
            this.procnameLBL = new System.Windows.Forms.Label();
            this.PHactionsGB = new System.Windows.Forms.GroupBox();
            this.PHresumeBTN = new System.Windows.Forms.Button();
            this.PHsuspendBTN = new System.Windows.Forms.Button();
            this.PHkillBTN = new System.Windows.Forms.Button();
            this.PHstartBTN = new System.Windows.Forms.Button();
            this.PHsettingsGB = new System.Windows.Forms.GroupBox();
            this.startSuspendedCB = new System.Windows.Forms.CheckBox();
            this.PHdelayAfterUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PHdelayBeforeUD = new System.Windows.Forms.NumericUpDown();
            this.PHtargetGB = new System.Windows.Forms.GroupBox();
            this.sametargetashashCB = new System.Windows.Forms.CheckBox();
            this.PHtargetBTN = new System.Windows.Forms.Button();
            this.PHtargetTB = new System.Windows.Forms.TextBox();
            this.mempeakLBL = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.targetGB.SuspendLayout();
            this.dllGB.SuspendLayout();
            this.settingsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdelayUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdelayUD)).BeginInit();
            this.actionGB.SuspendLayout();
            this.hashcheckerbpGB.SuspendLayout();
            this.processhackerGB.SuspendLayout();
            this.PHstatusGB.SuspendLayout();
            this.PHinfoGB.SuspendLayout();
            this.PHactionsGB.SuspendLayout();
            this.PHsettingsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHdelayAfterUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHdelayBeforeUD)).BeginInit();
            this.PHtargetGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetGB
            // 
            this.targetGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.targetGB.Controls.Add(this.btnTarget);
            this.targetGB.Controls.Add(this.targetTB);
            this.targetGB.ForeColor = System.Drawing.Color.White;
            this.targetGB.Location = new System.Drawing.Point(6, 25);
            this.targetGB.Name = "targetGB";
            this.targetGB.Size = new System.Drawing.Size(260, 134);
            this.targetGB.TabIndex = 9;
            this.targetGB.TabStop = false;
            this.targetGB.Text = "Target File";
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.Location = new System.Drawing.Point(16, 73);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(228, 42);
            this.btnTarget.TabIndex = 1;
            this.btnTarget.Text = "Select";
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // targetTB
            // 
            this.targetTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.targetTB.ForeColor = System.Drawing.Color.White;
            this.targetTB.Location = new System.Drawing.Point(16, 35);
            this.targetTB.Name = "targetTB";
            this.targetTB.Size = new System.Drawing.Size(228, 26);
            this.targetTB.TabIndex = 0;
            // 
            // dllGB
            // 
            this.dllGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dllGB.Controls.Add(this.btnReplacement);
            this.dllGB.Controls.Add(this.btnOriginal);
            this.dllGB.Controls.Add(this.replacementTB);
            this.dllGB.Controls.Add(this.label3);
            this.dllGB.Controls.Add(this.originalTB);
            this.dllGB.Controls.Add(this.label2);
            this.dllGB.ForeColor = System.Drawing.Color.White;
            this.dllGB.Location = new System.Drawing.Point(272, 25);
            this.dllGB.Name = "dllGB";
            this.dllGB.Size = new System.Drawing.Size(259, 273);
            this.dllGB.TabIndex = 10;
            this.dllGB.TabStop = false;
            this.dllGB.Text = "DLL to replace";
            // 
            // btnReplacement
            // 
            this.btnReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacement.Location = new System.Drawing.Point(15, 213);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(228, 42);
            this.btnReplacement.TabIndex = 5;
            this.btnReplacement.Text = "Select";
            this.btnReplacement.UseVisualStyleBackColor = false;
            this.btnReplacement.Click += new System.EventHandler(this.BtnReplacement_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginal.Location = new System.Drawing.Point(15, 87);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(228, 42);
            this.btnOriginal.TabIndex = 3;
            this.btnOriginal.Text = "Select";
            this.btnOriginal.UseVisualStyleBackColor = false;
            this.btnOriginal.Click += new System.EventHandler(this.BtnOriginal_Click);
            // 
            // replacementTB
            // 
            this.replacementTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.replacementTB.ForeColor = System.Drawing.Color.White;
            this.replacementTB.Location = new System.Drawing.Point(15, 175);
            this.replacementTB.Name = "replacementTB";
            this.replacementTB.Size = new System.Drawing.Size(228, 26);
            this.replacementTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Replacement";
            // 
            // originalTB
            // 
            this.originalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.originalTB.ForeColor = System.Drawing.Color.White;
            this.originalTB.Location = new System.Drawing.Point(15, 51);
            this.originalTB.Name = "originalTB";
            this.originalTB.Size = new System.Drawing.Size(228, 26);
            this.originalTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Original";
            // 
            // settingsGB
            // 
            this.settingsGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsGB.Controls.Add(this.AdelayUD);
            this.settingsGB.Controls.Add(this.label4);
            this.settingsGB.Controls.Add(this.label1);
            this.settingsGB.Controls.Add(this.BdelayUD);
            this.settingsGB.ForeColor = System.Drawing.Color.White;
            this.settingsGB.Location = new System.Drawing.Point(6, 165);
            this.settingsGB.Name = "settingsGB";
            this.settingsGB.Size = new System.Drawing.Size(260, 133);
            this.settingsGB.TabIndex = 12;
            this.settingsGB.TabStop = false;
            this.settingsGB.Text = "Settings";
            // 
            // AdelayUD
            // 
            this.AdelayUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdelayUD.ForeColor = System.Drawing.Color.White;
            this.AdelayUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AdelayUD.Location = new System.Drawing.Point(119, 83);
            this.AdelayUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AdelayUD.Name = "AdelayUD";
            this.AdelayUD.Size = new System.Drawing.Size(125, 26);
            this.AdelayUD.TabIndex = 15;
            this.AdelayUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delay After";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delay Before";
            // 
            // BdelayUD
            // 
            this.BdelayUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BdelayUD.ForeColor = System.Drawing.Color.White;
            this.BdelayUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BdelayUD.Location = new System.Drawing.Point(119, 35);
            this.BdelayUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BdelayUD.Name = "BdelayUD";
            this.BdelayUD.Size = new System.Drawing.Size(125, 26);
            this.BdelayUD.TabIndex = 12;
            this.BdelayUD.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // actionGB
            // 
            this.actionGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.actionGB.Controls.Add(this.btnReplaceOnly);
            this.actionGB.Controls.Add(this.btnNoBypass);
            this.actionGB.Controls.Add(this.btnBypass);
            this.actionGB.Controls.Add(this.btnRevert);
            this.actionGB.ForeColor = System.Drawing.Color.White;
            this.actionGB.Location = new System.Drawing.Point(6, 304);
            this.actionGB.Name = "actionGB";
            this.actionGB.Size = new System.Drawing.Size(525, 193);
            this.actionGB.TabIndex = 13;
            this.actionGB.TabStop = false;
            this.actionGB.Text = "Actions";
            // 
            // btnReplaceOnly
            // 
            this.btnReplaceOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReplaceOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceOnly.Location = new System.Drawing.Point(16, 135);
            this.btnReplaceOnly.Name = "btnReplaceOnly";
            this.btnReplaceOnly.Size = new System.Drawing.Size(244, 42);
            this.btnReplaceOnly.TabIndex = 9;
            this.btnReplaceOnly.Text = "Replace only";
            this.btnReplaceOnly.UseVisualStyleBackColor = false;
            this.btnReplaceOnly.Click += new System.EventHandler(this.BtnReplaceOnly_Click);
            // 
            // btnNoBypass
            // 
            this.btnNoBypass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNoBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoBypass.Location = new System.Drawing.Point(266, 135);
            this.btnNoBypass.Name = "btnNoBypass";
            this.btnNoBypass.Size = new System.Drawing.Size(244, 42);
            this.btnNoBypass.TabIndex = 8;
            this.btnNoBypass.Text = "Launch without Bypass";
            this.btnNoBypass.UseVisualStyleBackColor = false;
            this.btnNoBypass.Click += new System.EventHandler(this.BtnNoBypass_Click);
            // 
            // btnBypass
            // 
            this.btnBypass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBypass.ForeColor = System.Drawing.Color.White;
            this.btnBypass.Location = new System.Drawing.Point(16, 29);
            this.btnBypass.Name = "btnBypass";
            this.btnBypass.Size = new System.Drawing.Size(493, 42);
            this.btnBypass.TabIndex = 6;
            this.btnBypass.Text = "Bypass";
            this.btnBypass.UseVisualStyleBackColor = false;
            this.btnBypass.Click += new System.EventHandler(this.BtnBypass_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.Location = new System.Drawing.Point(16, 77);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(493, 42);
            this.btnRevert.TabIndex = 7;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.BtnRevert_Click);
            // 
            // hashcheckerbpGB
            // 
            this.hashcheckerbpGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.hashcheckerbpGB.Controls.Add(this.targetGB);
            this.hashcheckerbpGB.Controls.Add(this.actionGB);
            this.hashcheckerbpGB.Controls.Add(this.dllGB);
            this.hashcheckerbpGB.Controls.Add(this.settingsGB);
            this.hashcheckerbpGB.ForeColor = System.Drawing.Color.White;
            this.hashcheckerbpGB.Location = new System.Drawing.Point(12, 12);
            this.hashcheckerbpGB.Name = "hashcheckerbpGB";
            this.hashcheckerbpGB.Size = new System.Drawing.Size(538, 504);
            this.hashcheckerbpGB.TabIndex = 14;
            this.hashcheckerbpGB.TabStop = false;
            this.hashcheckerbpGB.Text = "Hash Checker Bypass";
            // 
            // processhackerGB
            // 
            this.processhackerGB.Controls.Add(this.PHstatusGB);
            this.processhackerGB.Controls.Add(this.PHinfoGB);
            this.processhackerGB.Controls.Add(this.PHactionsGB);
            this.processhackerGB.Controls.Add(this.PHsettingsGB);
            this.processhackerGB.Controls.Add(this.PHtargetGB);
            this.processhackerGB.ForeColor = System.Drawing.Color.White;
            this.processhackerGB.Location = new System.Drawing.Point(556, 12);
            this.processhackerGB.Name = "processhackerGB";
            this.processhackerGB.Size = new System.Drawing.Size(538, 504);
            this.processhackerGB.TabIndex = 15;
            this.processhackerGB.TabStop = false;
            this.processhackerGB.Text = "Process Hacker";
            // 
            // PHstatusGB
            // 
            this.PHstatusGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PHstatusGB.Controls.Add(this.updateBTN);
            this.PHstatusGB.Controls.Add(this.adminLBL);
            this.PHstatusGB.Controls.Add(this.statusLBL);
            this.PHstatusGB.Controls.Add(this.pidLBL);
            this.PHstatusGB.ForeColor = System.Drawing.Color.White;
            this.PHstatusGB.Location = new System.Drawing.Point(6, 327);
            this.PHstatusGB.Name = "PHstatusGB";
            this.PHstatusGB.Size = new System.Drawing.Size(259, 170);
            this.PHstatusGB.TabIndex = 18;
            this.PHstatusGB.TabStop = false;
            this.PHstatusGB.Text = "Status";
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.ForeColor = System.Drawing.Color.White;
            this.updateBTN.Location = new System.Drawing.Point(16, 117);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(228, 42);
            this.updateBTN.TabIndex = 11;
            this.updateBTN.Text = "Refresh ON";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // adminLBL
            // 
            this.adminLBL.AutoSize = true;
            this.adminLBL.BackColor = System.Drawing.Color.Transparent;
            this.adminLBL.Location = new System.Drawing.Point(12, 88);
            this.adminLBL.Name = "adminLBL";
            this.adminLBL.Size = new System.Drawing.Size(124, 20);
            this.adminLBL.TabIndex = 3;
            this.adminLBL.Text = "Admin: {ADMIN}";
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.BackColor = System.Drawing.Color.Transparent;
            this.statusLBL.Location = new System.Drawing.Point(12, 59);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(137, 20);
            this.statusLBL.TabIndex = 2;
            this.statusLBL.Text = "Status: {STATUS}";
            // 
            // pidLBL
            // 
            this.pidLBL.AutoSize = true;
            this.pidLBL.BackColor = System.Drawing.Color.Transparent;
            this.pidLBL.Location = new System.Drawing.Point(12, 28);
            this.pidLBL.Name = "pidLBL";
            this.pidLBL.Size = new System.Drawing.Size(132, 20);
            this.pidLBL.TabIndex = 0;
            this.pidLBL.Text = "Process ID: {PID}";
            // 
            // PHinfoGB
            // 
            this.PHinfoGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PHinfoGB.Controls.Add(this.mempeakLBL);
            this.PHinfoGB.Controls.Add(this.memusgLBL);
            this.PHinfoGB.Controls.Add(this.threadsLBL);
            this.PHinfoGB.Controls.Add(this.mwtitleLBL);
            this.PHinfoGB.Controls.Add(this.procnameLBL);
            this.PHinfoGB.ForeColor = System.Drawing.Color.White;
            this.PHinfoGB.Location = new System.Drawing.Point(272, 327);
            this.PHinfoGB.Name = "PHinfoGB";
            this.PHinfoGB.Size = new System.Drawing.Size(259, 170);
            this.PHinfoGB.TabIndex = 17;
            this.PHinfoGB.TabStop = false;
            this.PHinfoGB.Text = "Info";
            // 
            // memusgLBL
            // 
            this.memusgLBL.AutoSize = true;
            this.memusgLBL.BackColor = System.Drawing.Color.Transparent;
            this.memusgLBL.Location = new System.Drawing.Point(15, 113);
            this.memusgLBL.Name = "memusgLBL";
            this.memusgLBL.Size = new System.Drawing.Size(204, 20);
            this.memusgLBL.TabIndex = 4;
            this.memusgLBL.Text = "Memory usage: {MEMUSG}";
            // 
            // threadsLBL
            // 
            this.threadsLBL.AutoSize = true;
            this.threadsLBL.BackColor = System.Drawing.Color.Transparent;
            this.threadsLBL.Location = new System.Drawing.Point(15, 84);
            this.threadsLBL.Name = "threadsLBL";
            this.threadsLBL.Size = new System.Drawing.Size(163, 20);
            this.threadsLBL.TabIndex = 3;
            this.threadsLBL.Text = "Threads: {THREADS}";
            // 
            // mwtitleLBL
            // 
            this.mwtitleLBL.AutoSize = true;
            this.mwtitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.mwtitleLBL.Location = new System.Drawing.Point(15, 55);
            this.mwtitleLBL.Name = "mwtitleLBL";
            this.mwtitleLBL.Size = new System.Drawing.Size(217, 20);
            this.mwtitleLBL.TabIndex = 1;
            this.mwtitleLBL.Text = "MainWindowTitle: {MWTITLE}";
            // 
            // procnameLBL
            // 
            this.procnameLBL.AutoSize = true;
            this.procnameLBL.BackColor = System.Drawing.Color.Transparent;
            this.procnameLBL.Location = new System.Drawing.Point(15, 26);
            this.procnameLBL.Name = "procnameLBL";
            this.procnameLBL.Size = new System.Drawing.Size(215, 20);
            this.procnameLBL.TabIndex = 0;
            this.procnameLBL.Text = "Processname: {PROCNAME}";
            // 
            // PHactionsGB
            // 
            this.PHactionsGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PHactionsGB.Controls.Add(this.PHresumeBTN);
            this.PHactionsGB.Controls.Add(this.PHsuspendBTN);
            this.PHactionsGB.Controls.Add(this.PHkillBTN);
            this.PHactionsGB.Controls.Add(this.PHstartBTN);
            this.PHactionsGB.ForeColor = System.Drawing.Color.White;
            this.PHactionsGB.Location = new System.Drawing.Point(6, 191);
            this.PHactionsGB.Name = "PHactionsGB";
            this.PHactionsGB.Size = new System.Drawing.Size(525, 130);
            this.PHactionsGB.TabIndex = 14;
            this.PHactionsGB.TabStop = false;
            this.PHactionsGB.Text = "Actions";
            // 
            // PHresumeBTN
            // 
            this.PHresumeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHresumeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PHresumeBTN.Location = new System.Drawing.Point(266, 73);
            this.PHresumeBTN.Name = "PHresumeBTN";
            this.PHresumeBTN.Size = new System.Drawing.Size(244, 42);
            this.PHresumeBTN.TabIndex = 10;
            this.PHresumeBTN.Text = "Resume";
            this.PHresumeBTN.UseVisualStyleBackColor = false;
            this.PHresumeBTN.Click += new System.EventHandler(this.PHresumeBTN_Click);
            // 
            // PHsuspendBTN
            // 
            this.PHsuspendBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHsuspendBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PHsuspendBTN.Location = new System.Drawing.Point(16, 73);
            this.PHsuspendBTN.Name = "PHsuspendBTN";
            this.PHsuspendBTN.Size = new System.Drawing.Size(244, 42);
            this.PHsuspendBTN.TabIndex = 9;
            this.PHsuspendBTN.Text = "Suspend";
            this.PHsuspendBTN.UseVisualStyleBackColor = false;
            this.PHsuspendBTN.Click += new System.EventHandler(this.PHsuspendBTN_Click);
            // 
            // PHkillBTN
            // 
            this.PHkillBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHkillBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PHkillBTN.Location = new System.Drawing.Point(266, 25);
            this.PHkillBTN.Name = "PHkillBTN";
            this.PHkillBTN.Size = new System.Drawing.Size(244, 42);
            this.PHkillBTN.TabIndex = 8;
            this.PHkillBTN.Text = "Kill";
            this.PHkillBTN.UseVisualStyleBackColor = false;
            this.PHkillBTN.Click += new System.EventHandler(this.PHkillBTN_Click);
            // 
            // PHstartBTN
            // 
            this.PHstartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHstartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PHstartBTN.ForeColor = System.Drawing.Color.White;
            this.PHstartBTN.Location = new System.Drawing.Point(16, 25);
            this.PHstartBTN.Name = "PHstartBTN";
            this.PHstartBTN.Size = new System.Drawing.Size(244, 42);
            this.PHstartBTN.TabIndex = 6;
            this.PHstartBTN.Text = "Start";
            this.PHstartBTN.UseVisualStyleBackColor = false;
            this.PHstartBTN.Click += new System.EventHandler(this.PHstartBTN_Click);
            // 
            // PHsettingsGB
            // 
            this.PHsettingsGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PHsettingsGB.Controls.Add(this.startSuspendedCB);
            this.PHsettingsGB.Controls.Add(this.PHdelayAfterUD);
            this.PHsettingsGB.Controls.Add(this.label5);
            this.PHsettingsGB.Controls.Add(this.label6);
            this.PHsettingsGB.Controls.Add(this.PHdelayBeforeUD);
            this.PHsettingsGB.ForeColor = System.Drawing.Color.White;
            this.PHsettingsGB.Location = new System.Drawing.Point(272, 25);
            this.PHsettingsGB.Name = "PHsettingsGB";
            this.PHsettingsGB.Size = new System.Drawing.Size(260, 160);
            this.PHsettingsGB.TabIndex = 16;
            this.PHsettingsGB.TabStop = false;
            this.PHsettingsGB.Text = "Settings";
            // 
            // startSuspendedCB
            // 
            this.startSuspendedCB.AutoSize = true;
            this.startSuspendedCB.BackColor = System.Drawing.Color.Transparent;
            this.startSuspendedCB.Location = new System.Drawing.Point(19, 30);
            this.startSuspendedCB.Name = "startSuspendedCB";
            this.startSuspendedCB.Size = new System.Drawing.Size(156, 24);
            this.startSuspendedCB.TabIndex = 16;
            this.startSuspendedCB.Text = "Start Suspended";
            this.startSuspendedCB.UseVisualStyleBackColor = false;
            this.startSuspendedCB.CheckedChanged += new System.EventHandler(this.StartSuspendedCB_CheckedChanged);
            // 
            // PHdelayAfterUD
            // 
            this.PHdelayAfterUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHdelayAfterUD.Enabled = false;
            this.PHdelayAfterUD.ForeColor = System.Drawing.Color.White;
            this.PHdelayAfterUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PHdelayAfterUD.Location = new System.Drawing.Point(119, 113);
            this.PHdelayAfterUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PHdelayAfterUD.Name = "PHdelayAfterUD";
            this.PHdelayAfterUD.Size = new System.Drawing.Size(125, 26);
            this.PHdelayAfterUD.TabIndex = 15;
            this.PHdelayAfterUD.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(25, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delay After";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delay Before";
            // 
            // PHdelayBeforeUD
            // 
            this.PHdelayBeforeUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHdelayBeforeUD.Enabled = false;
            this.PHdelayBeforeUD.ForeColor = System.Drawing.Color.White;
            this.PHdelayBeforeUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PHdelayBeforeUD.Location = new System.Drawing.Point(119, 65);
            this.PHdelayBeforeUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PHdelayBeforeUD.Name = "PHdelayBeforeUD";
            this.PHdelayBeforeUD.Size = new System.Drawing.Size(125, 26);
            this.PHdelayBeforeUD.TabIndex = 12;
            this.PHdelayBeforeUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // PHtargetGB
            // 
            this.PHtargetGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PHtargetGB.Controls.Add(this.sametargetashashCB);
            this.PHtargetGB.Controls.Add(this.PHtargetBTN);
            this.PHtargetGB.Controls.Add(this.PHtargetTB);
            this.PHtargetGB.ForeColor = System.Drawing.Color.White;
            this.PHtargetGB.Location = new System.Drawing.Point(6, 25);
            this.PHtargetGB.Name = "PHtargetGB";
            this.PHtargetGB.Size = new System.Drawing.Size(260, 160);
            this.PHtargetGB.TabIndex = 10;
            this.PHtargetGB.TabStop = false;
            this.PHtargetGB.Text = "Target File";
            // 
            // sametargetashashCB
            // 
            this.sametargetashashCB.AutoSize = true;
            this.sametargetashashCB.BackColor = System.Drawing.Color.Transparent;
            this.sametargetashashCB.Location = new System.Drawing.Point(16, 124);
            this.sametargetashashCB.Name = "sametargetashashCB";
            this.sametargetashashCB.Size = new System.Drawing.Size(239, 24);
            this.sametargetashashCB.TabIndex = 2;
            this.sametargetashashCB.Text = "Same Target as Hash Check";
            this.sametargetashashCB.UseVisualStyleBackColor = false;
            this.sametargetashashCB.CheckedChanged += new System.EventHandler(this.SametargetashashCB_CheckedChanged);
            // 
            // PHtargetBTN
            // 
            this.PHtargetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHtargetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PHtargetBTN.Location = new System.Drawing.Point(16, 73);
            this.PHtargetBTN.Name = "PHtargetBTN";
            this.PHtargetBTN.Size = new System.Drawing.Size(228, 42);
            this.PHtargetBTN.TabIndex = 1;
            this.PHtargetBTN.Text = "Select";
            this.PHtargetBTN.UseVisualStyleBackColor = false;
            this.PHtargetBTN.Click += new System.EventHandler(this.PHtargetBTN_Click);
            // 
            // PHtargetTB
            // 
            this.PHtargetTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PHtargetTB.ForeColor = System.Drawing.Color.White;
            this.PHtargetTB.Location = new System.Drawing.Point(16, 35);
            this.PHtargetTB.Name = "PHtargetTB";
            this.PHtargetTB.Size = new System.Drawing.Size(228, 26);
            this.PHtargetTB.TabIndex = 0;
            // 
            // mempeakLBL
            // 
            this.mempeakLBL.AutoSize = true;
            this.mempeakLBL.BackColor = System.Drawing.Color.Transparent;
            this.mempeakLBL.Location = new System.Drawing.Point(15, 139);
            this.mempeakLBL.Name = "mempeakLBL";
            this.mempeakLBL.Size = new System.Drawing.Size(202, 20);
            this.mempeakLBL.TabIndex = 5;
            this.mempeakLBL.Text = "Memory Peak: {MEMPEAK}";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1108, 526);
            this.Controls.Add(this.processhackerGB);
            this.Controls.Add(this.hashcheckerbpGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BYTAGE | KNIF#0001 | https://knif.dev";
            this.targetGB.ResumeLayout(false);
            this.targetGB.PerformLayout();
            this.dllGB.ResumeLayout(false);
            this.dllGB.PerformLayout();
            this.settingsGB.ResumeLayout(false);
            this.settingsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdelayUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdelayUD)).EndInit();
            this.actionGB.ResumeLayout(false);
            this.hashcheckerbpGB.ResumeLayout(false);
            this.processhackerGB.ResumeLayout(false);
            this.PHstatusGB.ResumeLayout(false);
            this.PHstatusGB.PerformLayout();
            this.PHinfoGB.ResumeLayout(false);
            this.PHinfoGB.PerformLayout();
            this.PHactionsGB.ResumeLayout(false);
            this.PHsettingsGB.ResumeLayout(false);
            this.PHsettingsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHdelayAfterUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHdelayBeforeUD)).EndInit();
            this.PHtargetGB.ResumeLayout(false);
            this.PHtargetGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.GroupBox targetGB;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.TextBox targetTB;
        private System.Windows.Forms.GroupBox dllGB;
        private System.Windows.Forms.Button btnReplacement;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.TextBox replacementTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox originalTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox settingsGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BdelayUD;
        private System.Windows.Forms.GroupBox actionGB;
        private System.Windows.Forms.Button btnReplaceOnly;
        private System.Windows.Forms.Button btnNoBypass;
        private System.Windows.Forms.Button btnBypass;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.GroupBox hashcheckerbpGB;
        private System.Windows.Forms.GroupBox processhackerGB;
        private System.Windows.Forms.NumericUpDown AdelayUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox PHtargetGB;
        private System.Windows.Forms.Button PHtargetBTN;
        private System.Windows.Forms.TextBox PHtargetTB;
        private System.Windows.Forms.GroupBox PHsettingsGB;
        private System.Windows.Forms.NumericUpDown PHdelayAfterUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PHdelayBeforeUD;
        private System.Windows.Forms.GroupBox PHactionsGB;
        private System.Windows.Forms.Button PHsuspendBTN;
        private System.Windows.Forms.Button PHkillBTN;
        private System.Windows.Forms.Button PHstartBTN;
        private System.Windows.Forms.CheckBox sametargetashashCB;
        private System.Windows.Forms.CheckBox startSuspendedCB;
        private System.Windows.Forms.GroupBox PHinfoGB;
        private System.Windows.Forms.Label procnameLBL;
        private System.Windows.Forms.Button PHresumeBTN;
        private System.Windows.Forms.GroupBox PHstatusGB;
        private System.Windows.Forms.Label pidLBL;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label mwtitleLBL;
        private System.Windows.Forms.Label threadsLBL;
        private System.Windows.Forms.Label memusgLBL;
        private System.Windows.Forms.Label adminLBL;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Label mempeakLBL;
        private System.Windows.Forms.Timer tmr;
    }
}


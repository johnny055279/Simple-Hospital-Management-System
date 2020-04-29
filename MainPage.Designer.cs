namespace HospitalManageSystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.memberCentreBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taiwanCDCBtn = new System.Windows.Forms.Button();
            this.usCDCBtn = new System.Windows.Forms.Button();
            this.whoBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.medicalRecordBtn = new System.Windows.Forms.Button();
            this.patientDetailBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pillsBtn = new System.Windows.Forms.Button();
            this.moneyBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberCentreBtn
            // 
            this.memberCentreBtn.BackColor = System.Drawing.Color.Transparent;
            this.memberCentreBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memberCentreBtn.BackgroundImage")));
            this.memberCentreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memberCentreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberCentreBtn.FlatAppearance.BorderSize = 0;
            this.memberCentreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberCentreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.memberCentreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberCentreBtn.Location = new System.Drawing.Point(14, 177);
            this.memberCentreBtn.Name = "memberCentreBtn";
            this.memberCentreBtn.Size = new System.Drawing.Size(170, 170);
            this.memberCentreBtn.TabIndex = 0;
            this.memberCentreBtn.UseVisualStyleBackColor = false;
            this.memberCentreBtn.Click += new System.EventHandler(this.memberCentreBtn_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.BackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarBtn.BackgroundImage")));
            this.calendarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarBtn.FlatAppearance.BorderSize = 0;
            this.calendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarBtn.Location = new System.Drawing.Point(190, 177);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(170, 170);
            this.calendarBtn.TabIndex = 4;
            this.calendarBtn.UseVisualStyleBackColor = false;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1380, 34);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(81, 30);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.aboutToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(143, 30);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.taiwanCDCBtn);
            this.groupBox1.Controls.Add(this.usCDCBtn);
            this.groupBox1.Controls.Add(this.whoBtn);
            this.groupBox1.Controls.Add(this.webBrowser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(738, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 753);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "News";
            // 
            // taiwanCDCBtn
            // 
            this.taiwanCDCBtn.BackColor = System.Drawing.Color.White;
            this.taiwanCDCBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taiwanCDCBtn.BackgroundImage")));
            this.taiwanCDCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taiwanCDCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taiwanCDCBtn.FlatAppearance.BorderSize = 0;
            this.taiwanCDCBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.taiwanCDCBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.taiwanCDCBtn.Location = new System.Drawing.Point(373, 43);
            this.taiwanCDCBtn.Name = "taiwanCDCBtn";
            this.taiwanCDCBtn.Size = new System.Drawing.Size(264, 80);
            this.taiwanCDCBtn.TabIndex = 14;
            this.taiwanCDCBtn.UseVisualStyleBackColor = false;
            this.taiwanCDCBtn.Click += new System.EventHandler(this.taiwanCDCBtn_Click);
            // 
            // usCDCBtn
            // 
            this.usCDCBtn.BackColor = System.Drawing.Color.White;
            this.usCDCBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usCDCBtn.BackgroundImage")));
            this.usCDCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usCDCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usCDCBtn.FlatAppearance.BorderSize = 0;
            this.usCDCBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.usCDCBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.usCDCBtn.Location = new System.Drawing.Point(254, 43);
            this.usCDCBtn.Name = "usCDCBtn";
            this.usCDCBtn.Size = new System.Drawing.Size(122, 80);
            this.usCDCBtn.TabIndex = 13;
            this.usCDCBtn.UseVisualStyleBackColor = false;
            this.usCDCBtn.Click += new System.EventHandler(this.usCDCBtn_Click);
            // 
            // whoBtn
            // 
            this.whoBtn.BackColor = System.Drawing.Color.White;
            this.whoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whoBtn.BackgroundImage")));
            this.whoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whoBtn.FlatAppearance.BorderSize = 0;
            this.whoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.whoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.whoBtn.Location = new System.Drawing.Point(4, 43);
            this.whoBtn.Name = "whoBtn";
            this.whoBtn.Size = new System.Drawing.Size(254, 80);
            this.whoBtn.TabIndex = 11;
            this.whoBtn.UseVisualStyleBackColor = false;
            this.whoBtn.Click += new System.EventHandler(this.whoBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(6, 123);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(630, 628);
            this.webBrowser.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome Back!";
            // 
            // medicalRecordBtn
            // 
            this.medicalRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.medicalRecordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medicalRecordBtn.BackgroundImage")));
            this.medicalRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medicalRecordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicalRecordBtn.Enabled = false;
            this.medicalRecordBtn.FlatAppearance.BorderSize = 0;
            this.medicalRecordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicalRecordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.medicalRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicalRecordBtn.Location = new System.Drawing.Point(542, 177);
            this.medicalRecordBtn.Name = "medicalRecordBtn";
            this.medicalRecordBtn.Size = new System.Drawing.Size(170, 170);
            this.medicalRecordBtn.TabIndex = 11;
            this.medicalRecordBtn.UseVisualStyleBackColor = false;
            this.medicalRecordBtn.Visible = false;
            this.medicalRecordBtn.Click += new System.EventHandler(this.medicalRecordBtn_Click);
            // 
            // patientDetailBtn
            // 
            this.patientDetailBtn.BackColor = System.Drawing.Color.Transparent;
            this.patientDetailBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patientDetailBtn.BackgroundImage")));
            this.patientDetailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patientDetailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientDetailBtn.FlatAppearance.BorderSize = 0;
            this.patientDetailBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientDetailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.patientDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientDetailBtn.Location = new System.Drawing.Point(366, 177);
            this.patientDetailBtn.Name = "patientDetailBtn";
            this.patientDetailBtn.Size = new System.Drawing.Size(170, 170);
            this.patientDetailBtn.TabIndex = 12;
            this.patientDetailBtn.UseVisualStyleBackColor = false;
            this.patientDetailBtn.Click += new System.EventHandler(this.patientDetailBtn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.timeLabel.Location = new System.Drawing.Point(15, 110);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(76, 35);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "label2";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 36);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.richTextBox);
            this.splitContainer.Panel2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer.Size = new System.Drawing.Size(714, 335);
            this.splitContainer.SplitterDistance = 306;
            this.splitContainer.TabIndex = 14;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(306, 335);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 23);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox.Location = new System.Drawing.Point(0, 26);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(404, 309);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.splitContainer);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 374);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "留言板";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(644, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "重新整理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(269, 56);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(251, 54);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "Welcome Back!";
            // 
            // pillsBtn
            // 
            this.pillsBtn.BackColor = System.Drawing.Color.Transparent;
            this.pillsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pillsBtn.BackgroundImage")));
            this.pillsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pillsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pillsBtn.Enabled = false;
            this.pillsBtn.FlatAppearance.BorderSize = 0;
            this.pillsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pillsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.pillsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillsBtn.Location = new System.Drawing.Point(542, 177);
            this.pillsBtn.Name = "pillsBtn";
            this.pillsBtn.Size = new System.Drawing.Size(170, 170);
            this.pillsBtn.TabIndex = 17;
            this.pillsBtn.UseVisualStyleBackColor = false;
            this.pillsBtn.Visible = false;
            this.pillsBtn.Click += new System.EventHandler(this.pillsBtn_Click);
            // 
            // moneyBtn
            // 
            this.moneyBtn.BackColor = System.Drawing.Color.Transparent;
            this.moneyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moneyBtn.BackgroundImage")));
            this.moneyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moneyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moneyBtn.Enabled = false;
            this.moneyBtn.FlatAppearance.BorderSize = 0;
            this.moneyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moneyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.moneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyBtn.Location = new System.Drawing.Point(542, 177);
            this.moneyBtn.Name = "moneyBtn";
            this.moneyBtn.Size = new System.Drawing.Size(170, 170);
            this.moneyBtn.TabIndex = 18;
            this.moneyBtn.UseVisualStyleBackColor = false;
            this.moneyBtn.Visible = false;
            this.moneyBtn.Click += new System.EventHandler(this.moneyBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 787);
            this.Controls.Add(this.moneyBtn);
            this.Controls.Add(this.pillsBtn);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.patientDetailBtn);
            this.Controls.Add(this.medicalRecordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calendarBtn);
            this.Controls.Add(this.memberCentreBtn);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberCentreBtn;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button whoBtn;
        private System.Windows.Forms.Button usCDCBtn;
        private System.Windows.Forms.Button taiwanCDCBtn;
        private System.Windows.Forms.Button medicalRecordBtn;
        private System.Windows.Forms.Button patientDetailBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pillsBtn;
        private System.Windows.Forms.Button moneyBtn;
    }
}
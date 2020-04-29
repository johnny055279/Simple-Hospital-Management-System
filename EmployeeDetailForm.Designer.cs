namespace ControlLibrary
{
    partial class EmployeeDetailForm
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
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label accountLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label sexualLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label physicianIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.physicianIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.occupationTextBox = new System.Windows.Forms.ComboBox();
            this.departmentTextBox = new System.Windows.Forms.ComboBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexualTextBox = new System.Windows.Forms.TextBox();
            employeeIdLabel = new System.Windows.Forms.Label();
            accountLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            sexualLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            physicianIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.BackColor = System.Drawing.Color.Transparent;
            employeeIdLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIdLabel.Location = new System.Drawing.Point(139, 7);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(109, 26);
            employeeIdLabel.TabIndex = 1;
            employeeIdLabel.Text = "Employee Id:";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.BackColor = System.Drawing.Color.Transparent;
            accountLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountLabel.Location = new System.Drawing.Point(139, 38);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(78, 26);
            accountLabel.TabIndex = 3;
            accountLabel.Text = "Account:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(139, 69);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(100, 26);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(139, 100);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(97, 26);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            birthdayLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(139, 132);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(83, 26);
            birthdayLabel.TabIndex = 9;
            birthdayLabel.Text = "Birthday:";
            // 
            // sexualLabel
            // 
            sexualLabel.AutoSize = true;
            sexualLabel.BackColor = System.Drawing.Color.Transparent;
            sexualLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexualLabel.Location = new System.Drawing.Point(139, 162);
            sexualLabel.Name = "sexualLabel";
            sexualLabel.Size = new System.Drawing.Size(64, 26);
            sexualLabel.TabIndex = 11;
            sexualLabel.Text = "Sexual:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(139, 193);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(58, 26);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.BackColor = System.Drawing.Color.Transparent;
            occupationLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            occupationLabel.Location = new System.Drawing.Point(139, 224);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(101, 26);
            occupationLabel.TabIndex = 15;
            occupationLabel.Text = "Occupation:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.BackColor = System.Drawing.Color.Transparent;
            departmentLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(139, 255);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(110, 26);
            departmentLabel.TabIndex = 17;
            departmentLabel.Text = "Department:";
            // 
            // physicianIDLabel
            // 
            physicianIDLabel.AutoSize = true;
            physicianIDLabel.BackColor = System.Drawing.Color.Transparent;
            physicianIDLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            physicianIDLabel.Location = new System.Drawing.Point(139, 286);
            physicianIDLabel.Name = "physicianIDLabel";
            physicianIDLabel.Size = new System.Drawing.Size(109, 26);
            physicianIDLabel.TabIndex = 19;
            physicianIDLabel.Text = "Physician ID:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(250, 9);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.ReadOnly = true;
            this.employeeIdTextBox.Size = new System.Drawing.Size(200, 25);
            this.employeeIdTextBox.TabIndex = 2;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(250, 40);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.ReadOnly = true;
            this.accountTextBox.Size = new System.Drawing.Size(200, 25);
            this.accountTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(250, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(250, 102);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(250, 195);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(200, 25);
            this.emailTextBox.TabIndex = 14;
            // 
            // physicianIDTextBox
            // 
            this.physicianIDTextBox.Enabled = false;
            this.physicianIDTextBox.Location = new System.Drawing.Point(250, 288);
            this.physicianIDTextBox.Name = "physicianIDTextBox";
            this.physicianIDTextBox.ReadOnly = true;
            this.physicianIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.physicianIDTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(24, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(63, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occupationTextBox.Enabled = false;
            this.occupationTextBox.FormattingEnabled = true;
            this.occupationTextBox.Items.AddRange(new object[] {
            "內科醫生",
            "外科醫生",
            "護士",
            "藥師",
            "營養師",
            "財務人員",
            "行政人員",
            "研究員",
            "清潔員"});
            this.occupationTextBox.Location = new System.Drawing.Point(250, 228);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(200, 23);
            this.occupationTextBox.TabIndex = 25;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentTextBox.Enabled = false;
            this.departmentTextBox.FormattingEnabled = true;
            this.departmentTextBox.Items.AddRange(new object[] {
            "門診部",
            "急診部",
            "藥劑部",
            "內科部",
            "外科部",
            "小兒部",
            "神經部",
            "精神醫學部",
            "復健部",
            "骨科部",
            "耳鼻喉部",
            "創傷醫學部",
            "醫學研究部",
            "教學部"});
            this.departmentTextBox.Location = new System.Drawing.Point(250, 258);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(200, 23);
            this.departmentTextBox.TabIndex = 26;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(250, 133);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.birthdayDateTimePicker.TabIndex = 27;
            // 
            // sexualTextBox
            // 
            this.sexualTextBox.Enabled = false;
            this.sexualTextBox.Location = new System.Drawing.Point(250, 164);
            this.sexualTextBox.Name = "sexualTextBox";
            this.sexualTextBox.ReadOnly = true;
            this.sexualTextBox.Size = new System.Drawing.Size(200, 25);
            this.sexualTextBox.TabIndex = 12;
            // 
            // EmployeeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 330);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(accountLabel);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(sexualLabel);
            this.Controls.Add(this.sexualTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(physicianIDLabel);
            this.Controls.Add(this.physicianIDTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "EmployeeDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "員工資料";
            this.Load += new System.EventHandler(this.EmployeeDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.TextBox employeeIdTextBox;
        internal System.Windows.Forms.TextBox accountTextBox;
        internal System.Windows.Forms.TextBox firstNameTextBox;
        internal System.Windows.Forms.TextBox lastNameTextBox;
        internal System.Windows.Forms.TextBox emailTextBox;
        internal System.Windows.Forms.TextBox physicianIDTextBox;
        private System.Windows.Forms.ComboBox occupationTextBox;
        private System.Windows.Forms.ComboBox departmentTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        internal System.Windows.Forms.TextBox sexualTextBox;
    }
}
namespace HospitalManageSystem
{
    partial class PatientDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDataForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.allDataButton = new System.Windows.Forms.Button();
            this.dateSelectButton = new System.Windows.Forms.Button();
            this.docterSelectButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.symptomsRTB = new System.Windows.Forms.RichTextBox();
            this.adviceRTB = new System.Windows.Forms.RichTextBox();
            this.minDTP = new System.Windows.Forms.DateTimePicker();
            this.maxDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(539, 365);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // allDataButton
            // 
            this.allDataButton.AutoSize = true;
            this.allDataButton.BackColor = System.Drawing.Color.Transparent;
            this.allDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.allDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.allDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allDataButton.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allDataButton.Location = new System.Drawing.Point(12, 49);
            this.allDataButton.Name = "allDataButton";
            this.allDataButton.Size = new System.Drawing.Size(126, 31);
            this.allDataButton.TabIndex = 1;
            this.allDataButton.Text = "依所有資料";
            this.allDataButton.UseVisualStyleBackColor = false;
            this.allDataButton.Click += new System.EventHandler(this.allDataButton_Click);
            // 
            // dateSelectButton
            // 
            this.dateSelectButton.AutoSize = true;
            this.dateSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.dateSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dateSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.dateSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateSelectButton.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateSelectButton.Location = new System.Drawing.Point(12, 86);
            this.dateSelectButton.Name = "dateSelectButton";
            this.dateSelectButton.Size = new System.Drawing.Size(126, 31);
            this.dateSelectButton.TabIndex = 2;
            this.dateSelectButton.Text = "依日期查尋";
            this.dateSelectButton.UseVisualStyleBackColor = false;
            this.dateSelectButton.Click += new System.EventHandler(this.dateSelectButton_Click);
            // 
            // docterSelectButton
            // 
            this.docterSelectButton.AutoSize = true;
            this.docterSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.docterSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docterSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docterSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.docterSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docterSelectButton.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.docterSelectButton.Location = new System.Drawing.Point(10, 123);
            this.docterSelectButton.Name = "docterSelectButton";
            this.docterSelectButton.Size = new System.Drawing.Size(126, 31);
            this.docterSelectButton.TabIndex = 3;
            this.docterSelectButton.Text = "依醫師查尋";
            this.docterSelectButton.UseVisualStyleBackColor = false;
            this.docterSelectButton.Click += new System.EventHandler(this.docterSelectButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(142, 126);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(289, 28);
            this.comboBox.TabIndex = 4;
            // 
            // symptomsRTB
            // 
            this.symptomsRTB.Location = new System.Drawing.Point(6, 77);
            this.symptomsRTB.Name = "symptomsRTB";
            this.symptomsRTB.ReadOnly = true;
            this.symptomsRTB.Size = new System.Drawing.Size(575, 177);
            this.symptomsRTB.TabIndex = 5;
            this.symptomsRTB.Text = "";
            // 
            // adviceRTB
            // 
            this.adviceRTB.Location = new System.Drawing.Point(6, 291);
            this.adviceRTB.Name = "adviceRTB";
            this.adviceRTB.ReadOnly = true;
            this.adviceRTB.Size = new System.Drawing.Size(575, 234);
            this.adviceRTB.TabIndex = 6;
            this.adviceRTB.Text = "";
            // 
            // minDTP
            // 
            this.minDTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.minDTP.Location = new System.Drawing.Point(144, 86);
            this.minDTP.Name = "minDTP";
            this.minDTP.Size = new System.Drawing.Size(127, 30);
            this.minDTP.TabIndex = 7;
            // 
            // maxDTP
            // 
            this.maxDTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maxDTP.Location = new System.Drawing.Point(306, 87);
            this.maxDTP.Name = "maxDTP";
            this.maxDTP.Size = new System.Drawing.Size(127, 30);
            this.maxDTP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(273, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "至";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.symptomsRTB);
            this.groupBox1.Controls.Add(this.adviceRTB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(557, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 537);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "詳細敘述";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "醫生囑言：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(6, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "診斷病徵：";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxDTP);
            this.Controls.Add(this.minDTP);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.docterSelectButton);
            this.Controls.Add(this.dateSelectButton);
            this.Controls.Add(this.allDataButton);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientDataForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個案資料";
            this.Load += new System.EventHandler(this.PatientDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button allDataButton;
        private System.Windows.Forms.Button dateSelectButton;
        private System.Windows.Forms.Button docterSelectButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RichTextBox symptomsRTB;
        private System.Windows.Forms.RichTextBox adviceRTB;
        private System.Windows.Forms.DateTimePicker minDTP;
        private System.Windows.Forms.DateTimePicker maxDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}
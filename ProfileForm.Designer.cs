namespace HospitalManageSystem
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.profileTreeView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.undoButton = new System.Windows.Forms.Button();
            this.profileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.profileGroupBox.Controls.Add(this.splitContainer);
            this.profileGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profileGroupBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.profileGroupBox.Location = new System.Drawing.Point(0, 82);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(957, 456);
            this.profileGroupBox.TabIndex = 0;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "員工資料";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 27);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.profileTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(951, 426);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 0;
            // 
            // profileTreeView
            // 
            this.profileTreeView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTreeView.HotTracking = true;
            this.profileTreeView.Location = new System.Drawing.Point(0, 0);
            this.profileTreeView.Name = "profileTreeView";
            this.profileTreeView.Size = new System.Drawing.Size(200, 426);
            this.profileTreeView.TabIndex = 0;
            this.profileTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.profileTreeView_AfterSelect);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(747, 426);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Transparent;
            this.undoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoButton.BackgroundImage")));
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.undoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Location = new System.Drawing.Point(12, 12);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(65, 65);
            this.undoButton.TabIndex = 1;
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 538);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.profileGroupBox);
            this.Name = "ProfileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "員工資料";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.profileGroupBox.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView profileTreeView;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
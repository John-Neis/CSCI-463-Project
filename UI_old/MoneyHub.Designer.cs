namespace MoneyHub_User_Interface
{
    partial class MoneyHubHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyHubHome));
            this.appBasePanel = new System.Windows.Forms.Panel();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.optionsPanelBase = new System.Windows.Forms.Panel();
            this.nameAndVersionPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.upperSideBasePanel = new System.Windows.Forms.Panel();
            this.moneyHubTitlePanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MoneyHubLabel = new System.Windows.Forms.Label();
            this.welcomeUserPanel = new System.Windows.Forms.Panel();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.appBasePanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.optionsPanelBase.SuspendLayout();
            this.nameAndVersionPanel.SuspendLayout();
            this.moneyHubTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.welcomeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appBasePanel
            // 
            this.appBasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appBasePanel.Controls.Add(this.navBarPanel);
            this.appBasePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.appBasePanel.Location = new System.Drawing.Point(266, 0);
            this.appBasePanel.Margin = new System.Windows.Forms.Padding(4);
            this.appBasePanel.Name = "appBasePanel";
            this.appBasePanel.Size = new System.Drawing.Size(1077, 965);
            this.appBasePanel.TabIndex = 0;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navBarPanel.Controls.Add(this.minimizePictureBox);
            this.navBarPanel.Controls.Add(this.welcomeUserPanel);
            this.navBarPanel.Controls.Add(this.logoutPictureBox);
            this.navBarPanel.Controls.Add(this.settingsPictureBox);
            this.navBarPanel.Controls.Add(this.exitPictureBox);
            this.navBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarPanel.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(1075, 57);
            this.navBarPanel.TabIndex = 0;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutPictureBox.Image")));
            this.logoutPictureBox.Location = new System.Drawing.Point(942, 1);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(35, 55);
            this.logoutPictureBox.TabIndex = 2;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Tag = "Logout";
            this.logoutPictureBox.Visible = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.Image")));
            this.settingsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.InitialImage")));
            this.settingsPictureBox.Location = new System.Drawing.Point(977, -1);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(35, 55);
            this.settingsPictureBox.TabIndex = 1;
            this.settingsPictureBox.TabStop = false;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(1044, 0);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(29, 55);
            this.exitPictureBox.TabIndex = 0;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // optionsPanelBase
            // 
            this.optionsPanelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsPanelBase.Controls.Add(this.nameAndVersionPanel);
            this.optionsPanelBase.Controls.Add(this.upperSideBasePanel);
            this.optionsPanelBase.Controls.Add(this.moneyHubTitlePanel);
            this.optionsPanelBase.Location = new System.Drawing.Point(0, 0);
            this.optionsPanelBase.Margin = new System.Windows.Forms.Padding(4);
            this.optionsPanelBase.Name = "optionsPanelBase";
            this.optionsPanelBase.Size = new System.Drawing.Size(267, 962);
            this.optionsPanelBase.TabIndex = 1;
            // 
            // nameAndVersionPanel
            // 
            this.nameAndVersionPanel.Controls.Add(this.versionLabel);
            this.nameAndVersionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameAndVersionPanel.Location = new System.Drawing.Point(0, 933);
            this.nameAndVersionPanel.Name = "nameAndVersionPanel";
            this.nameAndVersionPanel.Size = new System.Drawing.Size(265, 27);
            this.nameAndVersionPanel.TabIndex = 4;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.versionLabel.Location = new System.Drawing.Point(3, 3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(90, 20);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Version 1.0";
            // 
            // upperSideBasePanel
            // 
            this.upperSideBasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperSideBasePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperSideBasePanel.Location = new System.Drawing.Point(0, 57);
            this.upperSideBasePanel.Name = "upperSideBasePanel";
            this.upperSideBasePanel.Size = new System.Drawing.Size(265, 875);
            this.upperSideBasePanel.TabIndex = 3;
            // 
            // moneyHubTitlePanel
            // 
            this.moneyHubTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyHubTitlePanel.Controls.Add(this.pictureBox4);
            this.moneyHubTitlePanel.Controls.Add(this.MoneyHubLabel);
            this.moneyHubTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.moneyHubTitlePanel.ForeColor = System.Drawing.Color.White;
            this.moneyHubTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.moneyHubTitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.moneyHubTitlePanel.Name = "moneyHubTitlePanel";
            this.moneyHubTitlePanel.Size = new System.Drawing.Size(265, 57);
            this.moneyHubTitlePanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(199, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // MoneyHubLabel
            // 
            this.MoneyHubLabel.AutoSize = true;
            this.MoneyHubLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyHubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.MoneyHubLabel.Location = new System.Drawing.Point(25, 10);
            this.MoneyHubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoneyHubLabel.Name = "MoneyHubLabel";
            this.MoneyHubLabel.Size = new System.Drawing.Size(167, 34);
            this.MoneyHubLabel.TabIndex = 0;
            this.MoneyHubLabel.Text = "Money Hub";
            this.MoneyHubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeUserPanel
            // 
            this.welcomeUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.welcomeUserPanel.Controls.Add(this.welcomeUserLabel);
            this.welcomeUserPanel.Location = new System.Drawing.Point(2, 2);
            this.welcomeUserPanel.Name = "welcomeUserPanel";
            this.welcomeUserPanel.Size = new System.Drawing.Size(934, 52);
            this.welcomeUserPanel.TabIndex = 3;
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUserLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeUserLabel.Location = new System.Drawing.Point(3, 9);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(134, 31);
            this.welcomeUserLabel.TabIndex = 0;
            this.welcomeUserLabel.Text = "Welcome,\r\n";
            this.welcomeUserLabel.Visible = false;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.Image")));
            this.minimizePictureBox.Location = new System.Drawing.Point(1014, 0);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(30, 55);
            this.minimizePictureBox.TabIndex = 4;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // MoneyHubHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1343, 965);
            this.Controls.Add(this.optionsPanelBase);
            this.Controls.Add(this.appBasePanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MoneyHubHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Hub";
            this.appBasePanel.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.optionsPanelBase.ResumeLayout(false);
            this.nameAndVersionPanel.ResumeLayout(false);
            this.nameAndVersionPanel.PerformLayout();
            this.moneyHubTitlePanel.ResumeLayout(false);
            this.moneyHubTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.welcomeUserPanel.ResumeLayout(false);
            this.welcomeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel appBasePanel;
        public System.Windows.Forms.Panel optionsPanelBase;
        public System.Windows.Forms.Panel moneyHubTitlePanel;
        public System.Windows.Forms.Label MoneyHubLabel;
        public System.Windows.Forms.Panel navBarPanel;
        public System.Windows.Forms.Panel upperSideBasePanel;
        private System.Windows.Forms.Panel nameAndVersionPanel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.PictureBox logoutPictureBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel welcomeUserPanel;
        public System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
    }
}


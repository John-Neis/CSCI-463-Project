namespace MoneyHub_User_Interface
{
    partial class Navigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigator));
            this.buttonOverview = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.selectedPanelIndicator = new System.Windows.Forms.Panel();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOverview
            // 
            this.buttonOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonOverview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOverview.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverview.ForeColor = System.Drawing.Color.White;
            this.buttonOverview.Image = ((System.Drawing.Image)(resources.GetObject("buttonOverview.Image")));
            this.buttonOverview.Location = new System.Drawing.Point(13, 3);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(252, 71);
            this.buttonOverview.TabIndex = 2;
            this.buttonOverview.Text = " Overview";
            this.buttonOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOverview.UseVisualStyleBackColor = false;
            this.buttonOverview.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.navPanel.Controls.Add(this.buttonSettings);
            this.navPanel.Controls.Add(this.selectedPanelIndicator);
            this.navPanel.Controls.Add(this.buttonAccount);
            this.navPanel.Controls.Add(this.buttonOverview);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(265, 875);
            this.navPanel.TabIndex = 5;
            // 
            // selectedPanelIndicator
            // 
            this.selectedPanelIndicator.BackColor = System.Drawing.Color.Olive;
            this.selectedPanelIndicator.Location = new System.Drawing.Point(1, 5);
            this.selectedPanelIndicator.Name = "selectedPanelIndicator";
            this.selectedPanelIndicator.Size = new System.Drawing.Size(10, 69);
            this.selectedPanelIndicator.TabIndex = 4;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccount.Image")));
            this.buttonAccount.Location = new System.Drawing.Point(13, 80);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(252, 71);
            this.buttonAccount.TabIndex = 3;
            this.buttonAccount.Text = "  Accounts";
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(13, 157);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(252, 71);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(265, 875);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Navigator";
            this.Text = "Navigator";
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel navPanel;
        public System.Windows.Forms.Button buttonOverview;
        private System.Windows.Forms.Panel selectedPanelIndicator;
        public System.Windows.Forms.Button buttonAccount;
        public System.Windows.Forms.Button buttonSettings;
    }
}
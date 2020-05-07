namespace MoneyHub_User_Interface
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsFormBasePanel = new System.Windows.Forms.Panel();
            this.settingsHeaderPanel = new System.Windows.Forms.Panel();
            this.settingsGearPictureBox = new System.Windows.Forms.PictureBox();
            this.settingsHeaderLabel = new System.Windows.Forms.Label();
            this.settingsContentPanel = new System.Windows.Forms.Panel();
            this.settingsOptionsPanel = new System.Windows.Forms.Panel();
            this.alertPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.clientSizeSettingsButton = new System.Windows.Forms.Button();
            this.clientSettingsLabel = new System.Windows.Forms.Label();
            this.accountSettingsLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.settingsFormBasePanel.SuspendLayout();
            this.settingsHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsGearPictureBox)).BeginInit();
            this.settingsOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsFormBasePanel
            // 
            this.settingsFormBasePanel.Controls.Add(this.settingsHeaderPanel);
            this.settingsFormBasePanel.Controls.Add(this.settingsContentPanel);
            this.settingsFormBasePanel.Controls.Add(this.settingsOptionsPanel);
            this.settingsFormBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsFormBasePanel.Location = new System.Drawing.Point(0, 0);
            this.settingsFormBasePanel.Name = "settingsFormBasePanel";
            this.settingsFormBasePanel.Size = new System.Drawing.Size(1077, 904);
            this.settingsFormBasePanel.TabIndex = 0;
            // 
            // settingsHeaderPanel
            // 
            this.settingsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.settingsHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsHeaderPanel.Controls.Add(this.settingsGearPictureBox);
            this.settingsHeaderPanel.Controls.Add(this.settingsHeaderLabel);
            this.settingsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsHeaderPanel.Name = "settingsHeaderPanel";
            this.settingsHeaderPanel.Size = new System.Drawing.Size(298, 71);
            this.settingsHeaderPanel.TabIndex = 0;
            // 
            // settingsGearPictureBox
            // 
            this.settingsGearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsGearPictureBox.Image")));
            this.settingsGearPictureBox.Location = new System.Drawing.Point(216, 9);
            this.settingsGearPictureBox.Name = "settingsGearPictureBox";
            this.settingsGearPictureBox.Size = new System.Drawing.Size(55, 53);
            this.settingsGearPictureBox.TabIndex = 1;
            this.settingsGearPictureBox.TabStop = false;
            // 
            // settingsHeaderLabel
            // 
            this.settingsHeaderLabel.Font = new System.Drawing.Font("Oxygen Mono", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.settingsHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.settingsHeaderLabel.Name = "settingsHeaderLabel";
            this.settingsHeaderLabel.Size = new System.Drawing.Size(198, 43);
            this.settingsHeaderLabel.TabIndex = 0;
            this.settingsHeaderLabel.Text = "Settings";
            this.settingsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsContentPanel
            // 
            this.settingsContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsContentPanel.Location = new System.Drawing.Point(298, 0);
            this.settingsContentPanel.Name = "settingsContentPanel";
            this.settingsContentPanel.Size = new System.Drawing.Size(779, 904);
            this.settingsContentPanel.TabIndex = 1;
            // 
            // settingsOptionsPanel
            // 
            this.settingsOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.settingsOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsOptionsPanel.Controls.Add(this.alertPictureBox);
            this.settingsOptionsPanel.Controls.Add(this.deleteAccountButton);
            this.settingsOptionsPanel.Controls.Add(this.clientSizeSettingsButton);
            this.settingsOptionsPanel.Controls.Add(this.clientSettingsLabel);
            this.settingsOptionsPanel.Controls.Add(this.accountSettingsLabel);
            this.settingsOptionsPanel.Controls.Add(this.changePasswordButton);
            this.settingsOptionsPanel.Font = new System.Drawing.Font("Panic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsOptionsPanel.Location = new System.Drawing.Point(3, 73);
            this.settingsOptionsPanel.Name = "settingsOptionsPanel";
            this.settingsOptionsPanel.Size = new System.Drawing.Size(295, 828);
            this.settingsOptionsPanel.TabIndex = 0;
            // 
            // alertPictureBox
            // 
            this.alertPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("alertPictureBox.Image")));
            this.alertPictureBox.Location = new System.Drawing.Point(184, 72);
            this.alertPictureBox.Name = "alertPictureBox";
            this.alertPictureBox.Size = new System.Drawing.Size(33, 30);
            this.alertPictureBox.TabIndex = 7;
            this.alertPictureBox.TabStop = false;
            this.alertPictureBox.Visible = false;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.deleteAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.deleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountButton.Font = new System.Drawing.Font("Panic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteAccountButton.Location = new System.Drawing.Point(4, 72);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(172, 30);
            this.deleteAccountButton.TabIndex = 6;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.MouseLeave += new System.EventHandler(this.deleteAccountButton_MouseLeave);
            this.deleteAccountButton.MouseHover += new System.EventHandler(this.deleteAccountButton_MouseHover);
            // 
            // clientSizeSettingsButton
            // 
            this.clientSizeSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientSizeSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clientSizeSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.clientSizeSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.clientSizeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientSizeSettingsButton.Font = new System.Drawing.Font("Panic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSizeSettingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clientSizeSettingsButton.Location = new System.Drawing.Point(4, 191);
            this.clientSizeSettingsButton.Name = "clientSizeSettingsButton";
            this.clientSizeSettingsButton.Size = new System.Drawing.Size(172, 30);
            this.clientSizeSettingsButton.TabIndex = 5;
            this.clientSizeSettingsButton.Text = "Client Size";
            this.clientSizeSettingsButton.UseVisualStyleBackColor = true;
            // 
            // clientSettingsLabel
            // 
            this.clientSettingsLabel.Font = new System.Drawing.Font("Panic Sans", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSettingsLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.clientSettingsLabel.Location = new System.Drawing.Point(1, 155);
            this.clientSettingsLabel.Name = "clientSettingsLabel";
            this.clientSettingsLabel.Size = new System.Drawing.Size(292, 33);
            this.clientSettingsLabel.TabIndex = 4;
            this.clientSettingsLabel.Text = "Client";
            this.clientSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountSettingsLabel
            // 
            this.accountSettingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountSettingsLabel.Font = new System.Drawing.Font("Panic Sans", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.accountSettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.accountSettingsLabel.Name = "accountSettingsLabel";
            this.accountSettingsLabel.Size = new System.Drawing.Size(293, 33);
            this.accountSettingsLabel.TabIndex = 1;
            this.accountSettingsLabel.Text = "Account";
            this.accountSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.changePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Panic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.SystemColors.Control;
            this.changePasswordButton.Location = new System.Drawing.Point(3, 36);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(173, 30);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1077, 904);
            this.Controls.Add(this.settingsFormBasePanel);
            this.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingsFormBasePanel.ResumeLayout(false);
            this.settingsHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsGearPictureBox)).EndInit();
            this.settingsOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel settingsFormBasePanel;
        public System.Windows.Forms.Panel settingsContentPanel;
        public System.Windows.Forms.Panel settingsOptionsPanel;
        public System.Windows.Forms.Panel settingsHeaderPanel;
        public System.Windows.Forms.Label settingsHeaderLabel;
        public System.Windows.Forms.Button changePasswordButton;
        public System.Windows.Forms.Button clientSizeSettingsButton;
        public System.Windows.Forms.Label clientSettingsLabel;
        public System.Windows.Forms.Label accountSettingsLabel;
        private System.Windows.Forms.PictureBox settingsGearPictureBox;
        public System.Windows.Forms.Button deleteAccountButton;
        public System.Windows.Forms.PictureBox alertPictureBox;
    }
}
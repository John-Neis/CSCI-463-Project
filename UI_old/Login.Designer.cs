namespace MoneyHub_User_Interface
{
    partial class Login
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.usernamePasswordInvalidText = new System.Windows.Forms.Label();
            this.createAccountForgotPasswordPanel = new System.Windows.Forms.Panel();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccountLink = new System.Windows.Forms.LinkLabel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.remeberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.loginPanel.SuspendLayout();
            this.createAccountForgotPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.remeberUserCheckBox);
            this.loginPanel.Controls.Add(this.usernamePasswordInvalidText);
            this.loginPanel.Controls.Add(this.createAccountForgotPasswordPanel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(265, 284);
            this.loginPanel.TabIndex = 4;
            // 
            // usernamePasswordInvalidText
            // 
            this.usernamePasswordInvalidText.AutoSize = true;
            this.usernamePasswordInvalidText.ForeColor = System.Drawing.Color.Brown;
            this.usernamePasswordInvalidText.Location = new System.Drawing.Point(17, 137);
            this.usernamePasswordInvalidText.Name = "usernamePasswordInvalidText";
            this.usernamePasswordInvalidText.Size = new System.Drawing.Size(207, 19);
            this.usernamePasswordInvalidText.TabIndex = 7;
            this.usernamePasswordInvalidText.Text = "Username or Password is Invalid";
            this.usernamePasswordInvalidText.Visible = false;
            // 
            // createAccountForgotPasswordPanel
            // 
            this.createAccountForgotPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createAccountForgotPasswordPanel.Controls.Add(this.forgotPasswordLink);
            this.createAccountForgotPasswordPanel.Controls.Add(this.label1);
            this.createAccountForgotPasswordPanel.Controls.Add(this.createAccountLink);
            this.createAccountForgotPasswordPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createAccountForgotPasswordPanel.Location = new System.Drawing.Point(0, 234);
            this.createAccountForgotPasswordPanel.Name = "createAccountForgotPasswordPanel";
            this.createAccountForgotPasswordPanel.Size = new System.Drawing.Size(263, 48);
            this.createAccountForgotPasswordPanel.TabIndex = 5;
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.ActiveLinkColor = System.Drawing.Color.Snow;
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.forgotPasswordLink.Location = new System.Drawing.Point(140, 12);
            this.forgotPasswordLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(118, 19);
            this.forgotPasswordLink.TabIndex = 5;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "or";
            // 
            // createAccountLink
            // 
            this.createAccountLink.ActiveLinkColor = System.Drawing.Color.Snow;
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.createAccountLink.Location = new System.Drawing.Point(0, 12);
            this.createAccountLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(124, 19);
            this.createAccountLink.TabIndex = 4;
            this.createAccountLink.TabStop = true;
            this.createAccountLink.Text = "Create an Account";
            this.createAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLink_LinkClicked);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(21, 113);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(231, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(21, 53);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(231, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(13, 194);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 33);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.passwordLabel.Location = new System.Drawing.Point(17, 90);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 19);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.usernameLabel.Location = new System.Drawing.Point(17, 30);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 19);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remeberUserCheckBox
            // 
            this.remeberUserCheckBox.AutoSize = true;
            this.remeberUserCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.remeberUserCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.remeberUserCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remeberUserCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.remeberUserCheckBox.Location = new System.Drawing.Point(21, 159);
            this.remeberUserCheckBox.Name = "remeberUserCheckBox";
            this.remeberUserCheckBox.Size = new System.Drawing.Size(145, 23);
            this.remeberUserCheckBox.TabIndex = 8;
            this.remeberUserCheckBox.Text = "Remeber Username";
            this.remeberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(265, 283);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.createAccountForgotPasswordPanel.ResumeLayout(false);
            this.createAccountForgotPasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel loginPanel;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Panel createAccountForgotPasswordPanel;
        public System.Windows.Forms.LinkLabel forgotPasswordLink;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel createAccountLink;
        public System.Windows.Forms.Label usernamePasswordInvalidText;
        public System.Windows.Forms.CheckBox remeberUserCheckBox;
    }
}
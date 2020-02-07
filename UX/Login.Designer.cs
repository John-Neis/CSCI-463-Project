namespace MoneyHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.createAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userInputPanel = new System.Windows.Forms.Panel();
            this.credentialsInvalidText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBasePanel = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.userInputPanel.SuspendLayout();
            this.loginBasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.Azure;
            this.loginPanel.Controls.Add(this.createAccountLinkLabel);
            this.loginPanel.Controls.Add(this.userInputPanel);
            this.loginPanel.Controls.Add(this.createAccountLabel);
            this.loginPanel.Controls.Add(this.newAccountLabel);
            this.loginPanel.Controls.Add(this.welcomeLabel);
            this.loginPanel.Location = new System.Drawing.Point(237, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(667, 616);
            this.loginPanel.TabIndex = 0;
            // 
            // createAccountLinkLabel
            // 
            this.createAccountLinkLabel.AutoSize = true;
            this.createAccountLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLinkLabel.Location = new System.Drawing.Point(307, 361);
            this.createAccountLinkLabel.Name = "createAccountLinkLabel";
            this.createAccountLinkLabel.Size = new System.Drawing.Size(35, 16);
            this.createAccountLinkLabel.TabIndex = 10;
            this.createAccountLinkLabel.TabStop = true;
            this.createAccountLinkLabel.Text = "here";
            this.createAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLinkLabel_LinkClicked);
            // 
            // userInputPanel
            // 
            this.userInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInputPanel.Controls.Add(this.credentialsInvalidText);
            this.userInputPanel.Controls.Add(this.usernameLabel);
            this.userInputPanel.Controls.Add(this.passwordLabel);
            this.userInputPanel.Controls.Add(this.passwordText);
            this.userInputPanel.Controls.Add(this.usernameText);
            this.userInputPanel.Controls.Add(this.loginButton);
            this.userInputPanel.Location = new System.Drawing.Point(103, 49);
            this.userInputPanel.Name = "userInputPanel";
            this.userInputPanel.Size = new System.Drawing.Size(460, 173);
            this.userInputPanel.TabIndex = 8;
            // 
            // credentialsInvalidText
            // 
            this.credentialsInvalidText.BackColor = System.Drawing.Color.Azure;
            this.credentialsInvalidText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credentialsInvalidText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.credentialsInvalidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsInvalidText.ForeColor = System.Drawing.Color.Red;
            this.credentialsInvalidText.Location = new System.Drawing.Point(133, 76);
            this.credentialsInvalidText.Name = "credentialsInvalidText";
            this.credentialsInvalidText.Size = new System.Drawing.Size(185, 14);
            this.credentialsInvalidText.TabIndex = 13;
            this.credentialsInvalidText.Text = "Username or Password Invali\r\nd";
            this.credentialsInvalidText.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(66, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(66, 50);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(177, 50);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(108, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(177, 13);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(108, 20);
            this.usernameText.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(177, 112);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 27);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.Enter += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.createAccountLabel.Location = new System.Drawing.Point(218, 361);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(74, 16);
            this.createAccountLabel.TabIndex = 11;
            this.createAccountLabel.Text = "Create one";
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.newAccountLabel.Location = new System.Drawing.Point(230, 336);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(196, 16);
            this.newAccountLabel.TabIndex = 9;
            this.newAccountLabel.Text = "Don\'t already have an account?";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Location = new System.Drawing.Point(276, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(133, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 616);
            this.panel1.TabIndex = 10;
            // 
            // loginBasePanel
            // 
            this.loginBasePanel.Controls.Add(this.panel1);
            this.loginBasePanel.Controls.Add(this.loginPanel);
            this.loginBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBasePanel.Location = new System.Drawing.Point(0, 0);
            this.loginBasePanel.Name = "loginBasePanel";
            this.loginBasePanel.Size = new System.Drawing.Size(904, 616);
            this.loginBasePanel.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 616);
            this.Controls.Add(this.loginBasePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyHub Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.userInputPanel.ResumeLayout(false);
            this.userInputPanel.PerformLayout();
            this.loginBasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel userInputPanel;
        private System.Windows.Forms.Label newAccountLabel;
        private System.Windows.Forms.LinkLabel createAccountLinkLabel;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.TextBox credentialsInvalidText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginBasePanel;
    }
}
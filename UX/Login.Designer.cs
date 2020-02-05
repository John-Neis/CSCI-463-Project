﻿namespace MoneyHub
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
            this.loginBasePanel = new System.Windows.Forms.Panel();
            this.userInputPanel = new System.Windows.Forms.Panel();
            this.credentialsInvalidText = new System.Windows.Forms.TextBox();
            this.createAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginBasePanel.SuspendLayout();
            this.userInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBasePanel
            // 
            this.loginBasePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBasePanel.BackColor = System.Drawing.Color.Azure;
            this.loginBasePanel.Controls.Add(this.userInputPanel);
            this.loginBasePanel.Controls.Add(this.welcomeLabel);
            this.loginBasePanel.Location = new System.Drawing.Point(3, 0);
            this.loginBasePanel.Name = "loginBasePanel";
            this.loginBasePanel.Size = new System.Drawing.Size(278, 288);
            this.loginBasePanel.TabIndex = 0;
            // 
            // userInputPanel
            // 
            this.userInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInputPanel.Controls.Add(this.credentialsInvalidText);
            this.userInputPanel.Controls.Add(this.createAccountLinkLabel);
            this.userInputPanel.Controls.Add(this.createAccountLabel);
            this.userInputPanel.Controls.Add(this.usernameLabel);
            this.userInputPanel.Controls.Add(this.passwordLabel);
            this.userInputPanel.Controls.Add(this.newAccountLabel);
            this.userInputPanel.Controls.Add(this.passwordText);
            this.userInputPanel.Controls.Add(this.usernameText);
            this.userInputPanel.Controls.Add(this.loginButton);
            this.userInputPanel.Location = new System.Drawing.Point(31, 51);
            this.userInputPanel.Name = "userInputPanel";
            this.userInputPanel.Size = new System.Drawing.Size(216, 210);
            this.userInputPanel.TabIndex = 8;
            // 
            // credentialsInvalidText
            // 
            this.credentialsInvalidText.BackColor = System.Drawing.Color.Azure;
            this.credentialsInvalidText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credentialsInvalidText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.credentialsInvalidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsInvalidText.ForeColor = System.Drawing.Color.Red;
            this.credentialsInvalidText.Location = new System.Drawing.Point(12, 82);
            this.credentialsInvalidText.Name = "credentialsInvalidText";
            this.credentialsInvalidText.Size = new System.Drawing.Size(177, 14);
            this.credentialsInvalidText.TabIndex = 13;
            this.credentialsInvalidText.Text = "Username or Password Invali\r\nd";
            this.credentialsInvalidText.Visible = false;
            // 
            // createAccountLinkLabel
            // 
            this.createAccountLinkLabel.AutoSize = true;
            this.createAccountLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLinkLabel.Location = new System.Drawing.Point(112, 168);
            this.createAccountLinkLabel.Name = "createAccountLinkLabel";
            this.createAccountLinkLabel.Size = new System.Drawing.Size(35, 16);
            this.createAccountLinkLabel.TabIndex = 10;
            this.createAccountLinkLabel.TabStop = true;
            this.createAccountLinkLabel.Text = "here";
            this.createAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLinkLabel_LinkClicked);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.Location = new System.Drawing.Point(42, 168);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(74, 16);
            this.createAccountLabel.TabIndex = 11;
            this.createAccountLabel.Text = "Create one";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(6, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 51);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.Location = new System.Drawing.Point(9, 143);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(196, 16);
            this.newAccountLabel.TabIndex = 9;
            this.newAccountLabel.Text = "Don\'t already have an account?";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(82, 51);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(82, 13);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 20);
            this.usernameText.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightGray;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(56, 107);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.Enter += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Location = new System.Drawing.Point(72, 19);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(133, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 288);
            this.Controls.Add(this.loginBasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyHub Login";
            this.loginBasePanel.ResumeLayout(false);
            this.loginBasePanel.PerformLayout();
            this.userInputPanel.ResumeLayout(false);
            this.userInputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginBasePanel;
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
    }
}
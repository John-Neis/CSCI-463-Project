namespace MoneyHub_User_Interface
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.loginBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeFormBasePanel = new System.Windows.Forms.Panel();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.recentChangesGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundPictureBox)).BeginInit();
            this.welcomeFormBasePanel.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.recentChangesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBackgroundPictureBox
            // 
            this.loginBackgroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBackgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBackgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginBackgroundPictureBox.Image")));
            this.loginBackgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loginBackgroundPictureBox.Name = "loginBackgroundPictureBox";
            this.loginBackgroundPictureBox.Size = new System.Drawing.Size(1074, 904);
            this.loginBackgroundPictureBox.TabIndex = 2;
            this.loginBackgroundPictureBox.TabStop = false;
            // 
            // welcomeFormBasePanel
            // 
            this.welcomeFormBasePanel.Controls.Add(this.newsPanel);
            this.welcomeFormBasePanel.Controls.Add(this.welcomeLabel);
            this.welcomeFormBasePanel.Controls.Add(this.loginBackgroundPictureBox);
            this.welcomeFormBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeFormBasePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeFormBasePanel.Name = "welcomeFormBasePanel";
            this.welcomeFormBasePanel.Size = new System.Drawing.Size(1074, 904);
            this.welcomeFormBasePanel.TabIndex = 6;
            // 
            // newsPanel
            // 
            this.newsPanel.Controls.Add(this.recentChangesGroupBox);
            this.newsPanel.Location = new System.Drawing.Point(12, 53);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(506, 402);
            this.newsPanel.TabIndex = 6;
            // 
            // recentChangesGroupBox
            // 
            this.recentChangesGroupBox.Controls.Add(this.richTextBox1);
            this.recentChangesGroupBox.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentChangesGroupBox.ForeColor = System.Drawing.Color.Peru;
            this.recentChangesGroupBox.Location = new System.Drawing.Point(13, 13);
            this.recentChangesGroupBox.Name = "recentChangesGroupBox";
            this.recentChangesGroupBox.Size = new System.Drawing.Size(487, 375);
            this.recentChangesGroupBox.TabIndex = 2;
            this.recentChangesGroupBox.TabStop = false;
            this.recentChangesGroupBox.Text = "Recent Changes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Tan;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 42);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(481, 330);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Orange;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(399, 41);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Welcome To MoneyHub!";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1074, 904);
            this.Controls.Add(this.welcomeFormBasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundPictureBox)).EndInit();
            this.welcomeFormBasePanel.ResumeLayout(false);
            this.welcomeFormBasePanel.PerformLayout();
            this.newsPanel.ResumeLayout(false);
            this.recentChangesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.PictureBox loginBackgroundPictureBox;
        public System.Windows.Forms.Panel welcomeFormBasePanel;
        public System.Windows.Forms.Panel newsPanel;
        public System.Windows.Forms.GroupBox recentChangesGroupBox;
        public System.Windows.Forms.Label welcomeLabel;
    }
}
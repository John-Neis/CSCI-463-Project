namespace MoneyHub
{
    partial class Home
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
            this.homeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeMenuStrip
            // 
            this.homeMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.homeMenuStrip.ImeMode = System.Windows.Forms.ImeMode.On;
            this.homeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.homeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.homeMenuStrip.Name = "homeMenuStrip";
            this.homeMenuStrip.Size = new System.Drawing.Size(1139, 24);
            this.homeMenuStrip.TabIndex = 0;
            this.homeMenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountDetailsToolStripMenuItem,
            this.manageAccountsToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountDetailsToolStripMenuItem.Text = "Account Details";
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAccountToolStripMenuItem.Text = "New Account";
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1139, 694);
            this.Controls.Add(this.homeMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.homeMenuStrip;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.homeMenuStrip.ResumeLayout(false);
            this.homeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip homeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
    }
}
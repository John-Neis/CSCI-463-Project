namespace MoneyHub_User_Interface
{
    partial class NetWorthBreakDownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetWorthBreakDownForm));
            this.netWorthBreakDownBasePanel = new System.Windows.Forms.Panel();
            this.netWorthBreakDownOptionsPanel = new System.Windows.Forms.Panel();
            this.netWorthCalcBasePanel = new System.Windows.Forms.Panel();
            this.totalNetWorthValue = new System.Windows.Forms.Label();
            this.totalNetWorthLabel = new System.Windows.Forms.Label();
            this.subtractLabel = new System.Windows.Forms.Label();
            this.loanAccountBalanceValue = new System.Windows.Forms.Label();
            this.loanAccountBalanceLabel = new System.Windows.Forms.Label();
            this.totalAssetsValue = new System.Windows.Forms.Label();
            this.totalAssestsLabel = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.savingsAccountBalanceValue = new System.Windows.Forms.Label();
            this.savingsAccountBalanceLabel = new System.Windows.Forms.Label();
            this.checkingAccountBalanceValue = new System.Windows.Forms.Label();
            this.checkingAccountBalanceLabel = new System.Windows.Forms.Label();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.nwBreakDownDescriptionLabel = new System.Windows.Forms.Label();
            this.NetWorthDescriptionRTbox = new System.Windows.Forms.RichTextBox();
            this.buttonSeeNetWorthHistory = new System.Windows.Forms.Button();
            this.netWorthCalculationLabel = new System.Windows.Forms.Label();
            this.netWorthHeaderPanel = new System.Windows.Forms.Panel();
            this.netWorthBreakDownImage = new System.Windows.Forms.PictureBox();
            this.netWorthBreakDownLabel = new System.Windows.Forms.Label();
            this.netWorthValue = new System.Windows.Forms.Label();
            this.CurrentNetWorthLabel = new System.Windows.Forms.Label();
            this.netWorthBreakDownBasePanel.SuspendLayout();
            this.netWorthBreakDownOptionsPanel.SuspendLayout();
            this.netWorthCalcBasePanel.SuspendLayout();
            this.netWorthHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthBreakDownImage)).BeginInit();
            this.SuspendLayout();
            // 
            // netWorthBreakDownBasePanel
            // 
            this.netWorthBreakDownBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.netWorthBreakDownBasePanel.Controls.Add(this.netWorthBreakDownOptionsPanel);
            this.netWorthBreakDownBasePanel.Controls.Add(this.netWorthHeaderPanel);
            this.netWorthBreakDownBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthBreakDownBasePanel.Location = new System.Drawing.Point(0, 0);
            this.netWorthBreakDownBasePanel.Name = "netWorthBreakDownBasePanel";
            this.netWorthBreakDownBasePanel.Size = new System.Drawing.Size(1069, 552);
            this.netWorthBreakDownBasePanel.TabIndex = 4;
            // 
            // netWorthBreakDownOptionsPanel
            // 
            this.netWorthBreakDownOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.netWorthCalcBasePanel);
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.addAccountButton);
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.nwBreakDownDescriptionLabel);
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.NetWorthDescriptionRTbox);
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.buttonSeeNetWorthHistory);
            this.netWorthBreakDownOptionsPanel.Controls.Add(this.netWorthCalculationLabel);
            this.netWorthBreakDownOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthBreakDownOptionsPanel.Location = new System.Drawing.Point(0, 57);
            this.netWorthBreakDownOptionsPanel.Name = "netWorthBreakDownOptionsPanel";
            this.netWorthBreakDownOptionsPanel.Size = new System.Drawing.Size(1069, 495);
            this.netWorthBreakDownOptionsPanel.TabIndex = 5;
            // 
            // netWorthCalcBasePanel
            // 
            this.netWorthCalcBasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthCalcBasePanel.Controls.Add(this.totalNetWorthValue);
            this.netWorthCalcBasePanel.Controls.Add(this.totalNetWorthLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.subtractLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.loanAccountBalanceValue);
            this.netWorthCalcBasePanel.Controls.Add(this.loanAccountBalanceLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.totalAssetsValue);
            this.netWorthCalcBasePanel.Controls.Add(this.totalAssestsLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.plusLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.savingsAccountBalanceValue);
            this.netWorthCalcBasePanel.Controls.Add(this.savingsAccountBalanceLabel);
            this.netWorthCalcBasePanel.Controls.Add(this.checkingAccountBalanceValue);
            this.netWorthCalcBasePanel.Controls.Add(this.checkingAccountBalanceLabel);
            this.netWorthCalcBasePanel.Location = new System.Drawing.Point(336, 46);
            this.netWorthCalcBasePanel.Name = "netWorthCalcBasePanel";
            this.netWorthCalcBasePanel.Size = new System.Drawing.Size(426, 190);
            this.netWorthCalcBasePanel.TabIndex = 12;
            // 
            // totalNetWorthValue
            // 
            this.totalNetWorthValue.AutoSize = true;
            this.totalNetWorthValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.totalNetWorthValue.Location = new System.Drawing.Point(308, 118);
            this.totalNetWorthValue.Name = "totalNetWorthValue";
            this.totalNetWorthValue.Size = new System.Drawing.Size(80, 22);
            this.totalNetWorthValue.TabIndex = 23;
            this.totalNetWorthValue.Text = "$000.00";
            // 
            // totalNetWorthLabel
            // 
            this.totalNetWorthLabel.AutoSize = true;
            this.totalNetWorthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.totalNetWorthLabel.Location = new System.Drawing.Point(13, 118);
            this.totalNetWorthLabel.Name = "totalNetWorthLabel";
            this.totalNetWorthLabel.Size = new System.Drawing.Size(170, 22);
            this.totalNetWorthLabel.TabIndex = 22;
            this.totalNetWorthLabel.Text = "Total Net Worth:";
            // 
            // subtractLabel
            // 
            this.subtractLabel.AutoSize = true;
            this.subtractLabel.Location = new System.Drawing.Point(282, 87);
            this.subtractLabel.Name = "subtractLabel";
            this.subtractLabel.Size = new System.Drawing.Size(20, 22);
            this.subtractLabel.TabIndex = 21;
            this.subtractLabel.Text = "-";
            // 
            // loanAccountBalanceValue
            // 
            this.loanAccountBalanceValue.AutoSize = true;
            this.loanAccountBalanceValue.ForeColor = System.Drawing.Color.IndianRed;
            this.loanAccountBalanceValue.Location = new System.Drawing.Point(308, 87);
            this.loanAccountBalanceValue.Name = "loanAccountBalanceValue";
            this.loanAccountBalanceValue.Size = new System.Drawing.Size(80, 22);
            this.loanAccountBalanceValue.TabIndex = 20;
            this.loanAccountBalanceValue.Text = "$000.00";
            // 
            // loanAccountBalanceLabel
            // 
            this.loanAccountBalanceLabel.AutoSize = true;
            this.loanAccountBalanceLabel.Location = new System.Drawing.Point(43, 87);
            this.loanAccountBalanceLabel.Name = "loanAccountBalanceLabel";
            this.loanAccountBalanceLabel.Size = new System.Drawing.Size(140, 22);
            this.loanAccountBalanceLabel.TabIndex = 19;
            this.loanAccountBalanceLabel.Text = "Loan Balance:";
            // 
            // totalAssetsValue
            // 
            this.totalAssetsValue.AutoSize = true;
            this.totalAssetsValue.ForeColor = System.Drawing.Color.Green;
            this.totalAssetsValue.Location = new System.Drawing.Point(308, 59);
            this.totalAssetsValue.Name = "totalAssetsValue";
            this.totalAssetsValue.Size = new System.Drawing.Size(80, 22);
            this.totalAssetsValue.TabIndex = 18;
            this.totalAssetsValue.Text = "$000.00";
            // 
            // totalAssestsLabel
            // 
            this.totalAssestsLabel.AutoSize = true;
            this.totalAssestsLabel.Location = new System.Drawing.Point(43, 59);
            this.totalAssestsLabel.Name = "totalAssestsLabel";
            this.totalAssestsLabel.Size = new System.Drawing.Size(140, 22);
            this.totalAssestsLabel.TabIndex = 17;
            this.totalAssestsLabel.Text = "Total Assets:";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(282, 31);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(20, 22);
            this.plusLabel.TabIndex = 16;
            this.plusLabel.Text = "+";
            // 
            // savingsAccountBalanceValue
            // 
            this.savingsAccountBalanceValue.AutoSize = true;
            this.savingsAccountBalanceValue.Location = new System.Drawing.Point(308, 31);
            this.savingsAccountBalanceValue.Name = "savingsAccountBalanceValue";
            this.savingsAccountBalanceValue.Size = new System.Drawing.Size(80, 22);
            this.savingsAccountBalanceValue.TabIndex = 15;
            this.savingsAccountBalanceValue.Text = "$000.00";
            // 
            // savingsAccountBalanceLabel
            // 
            this.savingsAccountBalanceLabel.AutoSize = true;
            this.savingsAccountBalanceLabel.Location = new System.Drawing.Point(13, 31);
            this.savingsAccountBalanceLabel.Name = "savingsAccountBalanceLabel";
            this.savingsAccountBalanceLabel.Size = new System.Drawing.Size(170, 22);
            this.savingsAccountBalanceLabel.TabIndex = 14;
            this.savingsAccountBalanceLabel.Text = "Savings Balance:";
            // 
            // checkingAccountBalanceValue
            // 
            this.checkingAccountBalanceValue.AutoSize = true;
            this.checkingAccountBalanceValue.Location = new System.Drawing.Point(308, 9);
            this.checkingAccountBalanceValue.Name = "checkingAccountBalanceValue";
            this.checkingAccountBalanceValue.Size = new System.Drawing.Size(80, 22);
            this.checkingAccountBalanceValue.TabIndex = 13;
            this.checkingAccountBalanceValue.Text = "$000.00";
            // 
            // checkingAccountBalanceLabel
            // 
            this.checkingAccountBalanceLabel.AutoSize = true;
            this.checkingAccountBalanceLabel.Location = new System.Drawing.Point(3, 9);
            this.checkingAccountBalanceLabel.Name = "checkingAccountBalanceLabel";
            this.checkingAccountBalanceLabel.Size = new System.Drawing.Size(180, 22);
            this.checkingAccountBalanceLabel.TabIndex = 12;
            this.checkingAccountBalanceLabel.Text = "Checking Balance:";
            // 
            // addAccountButton
            // 
            this.addAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addAccountButton.Location = new System.Drawing.Point(3, 242);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(283, 34);
            this.addAccountButton.TabIndex = 10;
            this.addAccountButton.Text = "Go To Add Accounts";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // nwBreakDownDescriptionLabel
            // 
            this.nwBreakDownDescriptionLabel.AutoSize = true;
            this.nwBreakDownDescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nwBreakDownDescriptionLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwBreakDownDescriptionLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.nwBreakDownDescriptionLabel.Location = new System.Drawing.Point(25, 10);
            this.nwBreakDownDescriptionLabel.Name = "nwBreakDownDescriptionLabel";
            this.nwBreakDownDescriptionLabel.Size = new System.Drawing.Size(225, 33);
            this.nwBreakDownDescriptionLabel.TabIndex = 9;
            this.nwBreakDownDescriptionLabel.Text = "Total Net Worth";
            // 
            // NetWorthDescriptionRTbox
            // 
            this.NetWorthDescriptionRTbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.NetWorthDescriptionRTbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.NetWorthDescriptionRTbox.Font = new System.Drawing.Font("Oxygen Mono", 9.75F);
            this.NetWorthDescriptionRTbox.ForeColor = System.Drawing.SystemColors.Window;
            this.NetWorthDescriptionRTbox.Location = new System.Drawing.Point(2, 46);
            this.NetWorthDescriptionRTbox.Name = "NetWorthDescriptionRTbox";
            this.NetWorthDescriptionRTbox.ReadOnly = true;
            this.NetWorthDescriptionRTbox.Size = new System.Drawing.Size(283, 190);
            this.NetWorthDescriptionRTbox.TabIndex = 8;
            this.NetWorthDescriptionRTbox.Text = resources.GetString("NetWorthDescriptionRTbox.Text");
            // 
            // buttonSeeNetWorthHistory
            // 
            this.buttonSeeNetWorthHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeeNetWorthHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSeeNetWorthHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSeeNetWorthHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeNetWorthHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeNetWorthHistory.Location = new System.Drawing.Point(3, 282);
            this.buttonSeeNetWorthHistory.Name = "buttonSeeNetWorthHistory";
            this.buttonSeeNetWorthHistory.Size = new System.Drawing.Size(283, 69);
            this.buttonSeeNetWorthHistory.TabIndex = 7;
            this.buttonSeeNetWorthHistory.Text = "Net Worth Over Time\r\n";
            this.buttonSeeNetWorthHistory.UseVisualStyleBackColor = true;
            this.buttonSeeNetWorthHistory.Click += new System.EventHandler(this.buttonSeeNetWorthHistory_Click);
            // 
            // netWorthCalculationLabel
            // 
            this.netWorthCalculationLabel.AutoSize = true;
            this.netWorthCalculationLabel.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthCalculationLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.netWorthCalculationLabel.Location = new System.Drawing.Point(452, 18);
            this.netWorthCalculationLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.netWorthCalculationLabel.Name = "netWorthCalculationLabel";
            this.netWorthCalculationLabel.Size = new System.Drawing.Size(220, 22);
            this.netWorthCalculationLabel.TabIndex = 11;
            this.netWorthCalculationLabel.Text = "Net Worth Calculation";
            // 
            // netWorthHeaderPanel
            // 
            this.netWorthHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthHeaderPanel.Controls.Add(this.netWorthBreakDownImage);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthBreakDownLabel);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthValue);
            this.netWorthHeaderPanel.Controls.Add(this.CurrentNetWorthLabel);
            this.netWorthHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.netWorthHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.netWorthHeaderPanel.Name = "netWorthHeaderPanel";
            this.netWorthHeaderPanel.Size = new System.Drawing.Size(1069, 57);
            this.netWorthHeaderPanel.TabIndex = 1;
            // 
            // netWorthBreakDownImage
            // 
            this.netWorthBreakDownImage.Image = ((System.Drawing.Image)(resources.GetObject("netWorthBreakDownImage.Image")));
            this.netWorthBreakDownImage.Location = new System.Drawing.Point(303, 2);
            this.netWorthBreakDownImage.Name = "netWorthBreakDownImage";
            this.netWorthBreakDownImage.Size = new System.Drawing.Size(60, 49);
            this.netWorthBreakDownImage.TabIndex = 1;
            this.netWorthBreakDownImage.TabStop = false;
            // 
            // netWorthBreakDownLabel
            // 
            this.netWorthBreakDownLabel.AutoSize = true;
            this.netWorthBreakDownLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthBreakDownLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.netWorthBreakDownLabel.Location = new System.Drawing.Point(16, 13);
            this.netWorthBreakDownLabel.Name = "netWorthBreakDownLabel";
            this.netWorthBreakDownLabel.Size = new System.Drawing.Size(281, 33);
            this.netWorthBreakDownLabel.TabIndex = 2;
            this.netWorthBreakDownLabel.Text = "Net Worth Breakdown";
            // 
            // netWorthValue
            // 
            this.netWorthValue.AutoSize = true;
            this.netWorthValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.netWorthValue.Location = new System.Drawing.Point(785, 13);
            this.netWorthValue.Name = "netWorthValue";
            this.netWorthValue.Size = new System.Drawing.Size(80, 22);
            this.netWorthValue.TabIndex = 1;
            this.netWorthValue.Text = "$ -1.00";
            // 
            // CurrentNetWorthLabel
            // 
            this.CurrentNetWorthLabel.AutoSize = true;
            this.CurrentNetWorthLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentNetWorthLabel.Location = new System.Drawing.Point(552, 13);
            this.CurrentNetWorthLabel.Name = "CurrentNetWorthLabel";
            this.CurrentNetWorthLabel.Size = new System.Drawing.Size(210, 22);
            this.CurrentNetWorthLabel.TabIndex = 0;
            this.CurrentNetWorthLabel.Text = "Current Net Worth:  ";
            // 
            // NetWorthBreakDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1069, 552);
            this.Controls.Add(this.netWorthBreakDownBasePanel);
            this.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NetWorthBreakDownForm";
            this.Text = "NetWorthHistoryForm";
            this.netWorthBreakDownBasePanel.ResumeLayout(false);
            this.netWorthBreakDownOptionsPanel.ResumeLayout(false);
            this.netWorthBreakDownOptionsPanel.PerformLayout();
            this.netWorthCalcBasePanel.ResumeLayout(false);
            this.netWorthCalcBasePanel.PerformLayout();
            this.netWorthHeaderPanel.ResumeLayout(false);
            this.netWorthHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthBreakDownImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel netWorthBreakDownBasePanel;
        public System.Windows.Forms.Panel netWorthHeaderPanel;
        private System.Windows.Forms.PictureBox netWorthBreakDownImage;
        private System.Windows.Forms.Label netWorthBreakDownLabel;
        public System.Windows.Forms.Label netWorthValue;
        public System.Windows.Forms.Label CurrentNetWorthLabel;
        private System.Windows.Forms.Panel netWorthBreakDownOptionsPanel;
        public System.Windows.Forms.Label nwBreakDownDescriptionLabel;
        public System.Windows.Forms.RichTextBox NetWorthDescriptionRTbox;
        public System.Windows.Forms.Button buttonSeeNetWorthHistory;
        public System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Panel netWorthCalcBasePanel;
        private System.Windows.Forms.Label netWorthCalculationLabel;
        private System.Windows.Forms.Label totalNetWorthLabel;
        private System.Windows.Forms.Label subtractLabel;
        private System.Windows.Forms.Label loanAccountBalanceLabel;
        private System.Windows.Forms.Label totalAssestsLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label savingsAccountBalanceLabel;
        private System.Windows.Forms.Label checkingAccountBalanceLabel;
        public System.Windows.Forms.Label totalNetWorthValue;
        public System.Windows.Forms.Label loanAccountBalanceValue;
        public System.Windows.Forms.Label totalAssetsValue;
        public System.Windows.Forms.Label savingsAccountBalanceValue;
        public System.Windows.Forms.Label checkingAccountBalanceValue;
    }
}
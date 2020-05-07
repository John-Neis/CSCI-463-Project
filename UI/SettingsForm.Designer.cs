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
            this.settingsFormBasePanel = new System.Windows.Forms.Panel();
            this.settingsOptionsPanel = new System.Windows.Forms.Panel();
            this.settingsContentPanel = new System.Windows.Forms.Panel();
            this.settingsHeaderPanel = new System.Windows.Forms.Panel();
            this.settingsHeaderLabel = new System.Windows.Forms.Label();
            this.seeCheckingDetailsButton = new System.Windows.Forms.Button();
            this.settingsFormBasePanel.SuspendLayout();
            this.settingsOptionsPanel.SuspendLayout();
            this.settingsHeaderPanel.SuspendLayout();
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
            // settingsOptionsPanel
            // 
            this.settingsOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsOptionsPanel.Controls.Add(this.seeCheckingDetailsButton);
            this.settingsOptionsPanel.Location = new System.Drawing.Point(34, 65);
            this.settingsOptionsPanel.Name = "settingsOptionsPanel";
            this.settingsOptionsPanel.Size = new System.Drawing.Size(386, 788);
            this.settingsOptionsPanel.TabIndex = 0;
            // 
            // settingsContentPanel
            // 
            this.settingsContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsContentPanel.Location = new System.Drawing.Point(426, 65);
            this.settingsContentPanel.Name = "settingsContentPanel";
            this.settingsContentPanel.Size = new System.Drawing.Size(624, 788);
            this.settingsContentPanel.TabIndex = 1;
            // 
            // settingsHeaderPanel
            // 
            this.settingsHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsHeaderPanel.Controls.Add(this.settingsHeaderLabel);
            this.settingsHeaderPanel.Location = new System.Drawing.Point(38, 3);
            this.settingsHeaderPanel.Name = "settingsHeaderPanel";
            this.settingsHeaderPanel.Size = new System.Drawing.Size(1012, 56);
            this.settingsHeaderPanel.TabIndex = 0;
            // 
            // settingsHeaderLabel
            // 
            this.settingsHeaderLabel.AutoSize = true;
            this.settingsHeaderLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHeaderLabel.Location = new System.Drawing.Point(3, 6);
            this.settingsHeaderLabel.Name = "settingsHeaderLabel";
            this.settingsHeaderLabel.Size = new System.Drawing.Size(127, 33);
            this.settingsHeaderLabel.TabIndex = 0;
            this.settingsHeaderLabel.Text = "Settings";
            // 
            // seeCheckingDetailsButton
            // 
            this.seeCheckingDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.seeCheckingDetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.seeCheckingDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.seeCheckingDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeCheckingDetailsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.seeCheckingDetailsButton.Location = new System.Drawing.Point(0, 0);
            this.seeCheckingDetailsButton.Name = "seeCheckingDetailsButton";
            this.seeCheckingDetailsButton.Size = new System.Drawing.Size(384, 53);
            this.seeCheckingDetailsButton.TabIndex = 3;
            this.seeCheckingDetailsButton.Text = "See Details";
            this.seeCheckingDetailsButton.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingsFormBasePanel.ResumeLayout(false);
            this.settingsOptionsPanel.ResumeLayout(false);
            this.settingsHeaderPanel.ResumeLayout(false);
            this.settingsHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel settingsFormBasePanel;
        public System.Windows.Forms.Panel settingsContentPanel;
        public System.Windows.Forms.Panel settingsOptionsPanel;
        public System.Windows.Forms.Panel settingsHeaderPanel;
        public System.Windows.Forms.Label settingsHeaderLabel;
        public System.Windows.Forms.Button seeCheckingDetailsButton;
    }
}
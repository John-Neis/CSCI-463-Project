namespace MoneyHub_User_Interface
{
    partial class AccountSummaryForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSummaryForm));
            this.accountSummaryBasePanel = new System.Windows.Forms.Panel();
            this.accountSummaryMenuPanel = new System.Windows.Forms.Panel();
            this.asMenuHeaderPanel = new System.Windows.Forms.Panel();
            this.accountOptionsLabel = new System.Windows.Forms.Label();
            this.accountSummaryContentBasePanel = new System.Windows.Forms.Panel();
            this.accountSummaryTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.liabilityDoughnutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.assetDoughnutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.accountSummaryHeaderPanel = new System.Windows.Forms.Panel();
            this.mhAcccountSummaryLabel = new System.Windows.Forms.Label();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.assetDetailsPanel = new System.Windows.Forms.Panel();
            this.checkingAccountDetailsPanel = new System.Windows.Forms.Panel();
            this.savingsAccountDetails = new System.Windows.Forms.Panel();
            this.liabilitiesDetailsPanel = new System.Windows.Forms.Panel();
            this.checkingAccounDetailstLabel = new System.Windows.Forms.Label();
            this.savingsAccountDetailsLabel = new System.Windows.Forms.Label();
            this.accountCheckingBalanceLabel = new System.Windows.Forms.Label();
            this.accountCheckingDateOpenedLabel = new System.Windows.Forms.Label();
            this.acountICheckingAPYLabel = new System.Windows.Forms.Label();
            this.accountCheckingBalanceValue = new System.Windows.Forms.Label();
            this.accountCheckingDateOpened = new System.Windows.Forms.Label();
            this.accountCheckingAPYValue = new System.Windows.Forms.Label();
            this.accountSavingsAPYValue = new System.Windows.Forms.Label();
            this.accountSavingsDateOpened = new System.Windows.Forms.Label();
            this.accountSavingsBalanceValue = new System.Windows.Forms.Label();
            this.accountSavingsAPYLabel = new System.Windows.Forms.Label();
            this.accountSavingsDateOpenedLabel = new System.Windows.Forms.Label();
            this.accountSavingsBalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountLoanDetailsPanel = new System.Windows.Forms.Panel();
            this.loanType = new System.Windows.Forms.Label();
            this.loanDateTakenLabel = new System.Windows.Forms.Label();
            this.loanBalanceRemainingValue = new System.Windows.Forms.Label();
            this.loanTakenDate = new System.Windows.Forms.Label();
            this.loanBalanceLabel = new System.Windows.Forms.Label();
            this.accountDebtLoanLabel = new System.Windows.Forms.Label();
            this.loanTypeLabel = new System.Windows.Forms.Label();
            this.loanInterestRate = new System.Windows.Forms.Label();
            this.loanInterestRateLabel = new System.Windows.Forms.Label();
            this.accountSummaryBasePanel.SuspendLayout();
            this.accountSummaryMenuPanel.SuspendLayout();
            this.asMenuHeaderPanel.SuspendLayout();
            this.accountSummaryContentBasePanel.SuspendLayout();
            this.accountSummaryTLPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liabilityDoughnutChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDoughnutChart)).BeginInit();
            this.accountSummaryHeaderPanel.SuspendLayout();
            this.assetDetailsPanel.SuspendLayout();
            this.checkingAccountDetailsPanel.SuspendLayout();
            this.savingsAccountDetails.SuspendLayout();
            this.liabilitiesDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.accountLoanDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountSummaryBasePanel
            // 
            this.accountSummaryBasePanel.Controls.Add(this.accountSummaryMenuPanel);
            this.accountSummaryBasePanel.Controls.Add(this.accountSummaryContentBasePanel);
            this.accountSummaryBasePanel.Controls.Add(this.accountSummaryHeaderPanel);
            this.accountSummaryBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountSummaryBasePanel.ForeColor = System.Drawing.Color.White;
            this.accountSummaryBasePanel.Location = new System.Drawing.Point(0, 0);
            this.accountSummaryBasePanel.Name = "accountSummaryBasePanel";
            this.accountSummaryBasePanel.Size = new System.Drawing.Size(1077, 904);
            this.accountSummaryBasePanel.TabIndex = 0;
            // 
            // accountSummaryMenuPanel
            // 
            this.accountSummaryMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.accountSummaryMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountSummaryMenuPanel.Controls.Add(this.addAccountButton);
            this.accountSummaryMenuPanel.Controls.Add(this.asMenuHeaderPanel);
            this.accountSummaryMenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.accountSummaryMenuPanel.Location = new System.Drawing.Point(887, 67);
            this.accountSummaryMenuPanel.Name = "accountSummaryMenuPanel";
            this.accountSummaryMenuPanel.Size = new System.Drawing.Size(190, 837);
            this.accountSummaryMenuPanel.TabIndex = 3;
            // 
            // asMenuHeaderPanel
            // 
            this.asMenuHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.asMenuHeaderPanel.Controls.Add(this.accountOptionsLabel);
            this.asMenuHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.asMenuHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.asMenuHeaderPanel.Name = "asMenuHeaderPanel";
            this.asMenuHeaderPanel.Size = new System.Drawing.Size(186, 46);
            this.asMenuHeaderPanel.TabIndex = 2;
            // 
            // accountOptionsLabel
            // 
            this.accountOptionsLabel.AutoSize = true;
            this.accountOptionsLabel.Font = new System.Drawing.Font("Oxygen Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountOptionsLabel.Location = new System.Drawing.Point(7, 9);
            this.accountOptionsLabel.Name = "accountOptionsLabel";
            this.accountOptionsLabel.Size = new System.Drawing.Size(177, 26);
            this.accountOptionsLabel.TabIndex = 1;
            this.accountOptionsLabel.Text = "Account Options";
            // 
            // accountSummaryContentBasePanel
            // 
            this.accountSummaryContentBasePanel.Controls.Add(this.accountSummaryTLPanel);
            this.accountSummaryContentBasePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountSummaryContentBasePanel.Location = new System.Drawing.Point(0, 67);
            this.accountSummaryContentBasePanel.Name = "accountSummaryContentBasePanel";
            this.accountSummaryContentBasePanel.Size = new System.Drawing.Size(881, 837);
            this.accountSummaryContentBasePanel.TabIndex = 2;
            // 
            // accountSummaryTLPanel
            // 
            this.accountSummaryTLPanel.ColumnCount = 2;
            this.accountSummaryTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.51354F));
            this.accountSummaryTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.48646F));
            this.accountSummaryTLPanel.Controls.Add(this.liabilityDoughnutChart, 0, 1);
            this.accountSummaryTLPanel.Controls.Add(this.assetDoughnutChart, 0, 0);
            this.accountSummaryTLPanel.Controls.Add(this.assetDetailsPanel, 1, 0);
            this.accountSummaryTLPanel.Controls.Add(this.liabilitiesDetailsPanel, 1, 1);
            this.accountSummaryTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountSummaryTLPanel.Location = new System.Drawing.Point(0, 0);
            this.accountSummaryTLPanel.Name = "accountSummaryTLPanel";
            this.accountSummaryTLPanel.RowCount = 2;
            this.accountSummaryTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40849F));
            this.accountSummaryTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.59151F));
            this.accountSummaryTLPanel.Size = new System.Drawing.Size(881, 837);
            this.accountSummaryTLPanel.TabIndex = 2;
            // 
            // liabilityDoughnutChart
            // 
            this.liabilityDoughnutChart.BackColor = System.Drawing.Color.DarkOrange;
            this.liabilityDoughnutChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.liabilityDoughnutChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.liabilityDoughnutChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.liabilityDoughnutChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.liabilityDoughnutChart.ChartAreas.Add(chartArea1);
            this.liabilityDoughnutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.liabilityDoughnutChart.Legends.Add(legend1);
            this.liabilityDoughnutChart.Location = new System.Drawing.Point(3, 408);
            this.liabilityDoughnutChart.Name = "liabilityDoughnutChart";
            this.liabilityDoughnutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.liabilityDoughnutChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series1.BorderColor = System.Drawing.Color.Turquoise;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Liabilities";
            this.liabilityDoughnutChart.Series.Add(series1);
            this.liabilityDoughnutChart.Size = new System.Drawing.Size(439, 426);
            this.liabilityDoughnutChart.TabIndex = 8;
            this.liabilityDoughnutChart.Text = "Liabilities";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Liabilities";
            title1.Text = "Liabilities (USD)";
            this.liabilityDoughnutChart.Titles.Add(title1);
            // 
            // assetDoughnutChart
            // 
            this.assetDoughnutChart.BackColor = System.Drawing.Color.SeaGreen;
            this.assetDoughnutChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.assetDoughnutChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.assetDoughnutChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.assetDoughnutChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.assetDoughnutChart.ChartAreas.Add(chartArea2);
            this.assetDoughnutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.assetDoughnutChart.Legends.Add(legend2);
            this.assetDoughnutChart.Location = new System.Drawing.Point(3, 3);
            this.assetDoughnutChart.Name = "assetDoughnutChart";
            this.assetDoughnutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.assetDoughnutChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series2.BorderColor = System.Drawing.Color.Turquoise;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Assets";
            this.assetDoughnutChart.Series.Add(series2);
            this.assetDoughnutChart.Size = new System.Drawing.Size(439, 399);
            this.assetDoughnutChart.TabIndex = 7;
            this.assetDoughnutChart.Text = "Assets";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Assets";
            title2.Text = "Assets (USD)";
            this.assetDoughnutChart.Titles.Add(title2);
            // 
            // accountSummaryHeaderPanel
            // 
            this.accountSummaryHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.accountSummaryHeaderPanel.Controls.Add(this.pictureBox1);
            this.accountSummaryHeaderPanel.Controls.Add(this.mhAcccountSummaryLabel);
            this.accountSummaryHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountSummaryHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.accountSummaryHeaderPanel.Name = "accountSummaryHeaderPanel";
            this.accountSummaryHeaderPanel.Size = new System.Drawing.Size(1077, 67);
            this.accountSummaryHeaderPanel.TabIndex = 1;
            // 
            // mhAcccountSummaryLabel
            // 
            this.mhAcccountSummaryLabel.AutoSize = true;
            this.mhAcccountSummaryLabel.Font = new System.Drawing.Font("Oxygen Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhAcccountSummaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.mhAcccountSummaryLabel.Location = new System.Drawing.Point(12, 9);
            this.mhAcccountSummaryLabel.Name = "mhAcccountSummaryLabel";
            this.mhAcccountSummaryLabel.Size = new System.Drawing.Size(484, 50);
            this.mhAcccountSummaryLabel.TabIndex = 0;
            this.mhAcccountSummaryLabel.Text = "My Money Hub Accounts";
            // 
            // addAccountButton
            // 
            this.addAccountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAccountButton.FlatAppearance.BorderSize = 0;
            this.addAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addAccountButton.Location = new System.Drawing.Point(0, 46);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(186, 53);
            this.addAccountButton.TabIndex = 4;
            this.addAccountButton.Text = "Link New Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            // 
            // assetDetailsPanel
            // 
            this.assetDetailsPanel.Controls.Add(this.checkingAccountDetailsPanel);
            this.assetDetailsPanel.Controls.Add(this.savingsAccountDetails);
            this.assetDetailsPanel.Font = new System.Drawing.Font("Panic Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetDetailsPanel.Location = new System.Drawing.Point(448, 3);
            this.assetDetailsPanel.Name = "assetDetailsPanel";
            this.assetDetailsPanel.Size = new System.Drawing.Size(430, 399);
            this.assetDetailsPanel.TabIndex = 9;
            // 
            // checkingAccountDetailsPanel
            // 
            this.checkingAccountDetailsPanel.Controls.Add(this.accountCheckingAPYValue);
            this.checkingAccountDetailsPanel.Controls.Add(this.accountCheckingDateOpened);
            this.checkingAccountDetailsPanel.Controls.Add(this.accountCheckingBalanceValue);
            this.checkingAccountDetailsPanel.Controls.Add(this.acountICheckingAPYLabel);
            this.checkingAccountDetailsPanel.Controls.Add(this.accountCheckingDateOpenedLabel);
            this.checkingAccountDetailsPanel.Controls.Add(this.accountCheckingBalanceLabel);
            this.checkingAccountDetailsPanel.Controls.Add(this.checkingAccounDetailstLabel);
            this.checkingAccountDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkingAccountDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.checkingAccountDetailsPanel.Name = "checkingAccountDetailsPanel";
            this.checkingAccountDetailsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkingAccountDetailsPanel.Size = new System.Drawing.Size(430, 194);
            this.checkingAccountDetailsPanel.TabIndex = 10;
            // 
            // savingsAccountDetails
            // 
            this.savingsAccountDetails.Controls.Add(this.accountSavingsAPYValue);
            this.savingsAccountDetails.Controls.Add(this.accountSavingsDateOpened);
            this.savingsAccountDetails.Controls.Add(this.accountSavingsBalanceValue);
            this.savingsAccountDetails.Controls.Add(this.accountSavingsAPYLabel);
            this.savingsAccountDetails.Controls.Add(this.accountSavingsDateOpenedLabel);
            this.savingsAccountDetails.Controls.Add(this.accountSavingsBalance);
            this.savingsAccountDetails.Controls.Add(this.savingsAccountDetailsLabel);
            this.savingsAccountDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savingsAccountDetails.Location = new System.Drawing.Point(0, 203);
            this.savingsAccountDetails.Name = "savingsAccountDetails";
            this.savingsAccountDetails.Size = new System.Drawing.Size(430, 196);
            this.savingsAccountDetails.TabIndex = 11;
            // 
            // liabilitiesDetailsPanel
            // 
            this.liabilitiesDetailsPanel.Controls.Add(this.accountLoanDetailsPanel);
            this.liabilitiesDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liabilitiesDetailsPanel.Font = new System.Drawing.Font("Panic Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liabilitiesDetailsPanel.Location = new System.Drawing.Point(448, 408);
            this.liabilitiesDetailsPanel.Name = "liabilitiesDetailsPanel";
            this.liabilitiesDetailsPanel.Size = new System.Drawing.Size(430, 426);
            this.liabilitiesDetailsPanel.TabIndex = 10;
            // 
            // checkingAccounDetailstLabel
            // 
            this.checkingAccounDetailstLabel.AutoSize = true;
            this.checkingAccounDetailstLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingAccounDetailstLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.checkingAccounDetailstLabel.Location = new System.Drawing.Point(4, 7);
            this.checkingAccounDetailstLabel.Name = "checkingAccounDetailstLabel";
            this.checkingAccounDetailstLabel.Size = new System.Drawing.Size(331, 23);
            this.checkingAccounDetailstLabel.TabIndex = 0;
            this.checkingAccounDetailstLabel.Text = "Details for Account: Checking";
            // 
            // savingsAccountDetailsLabel
            // 
            this.savingsAccountDetailsLabel.AutoSize = true;
            this.savingsAccountDetailsLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsAccountDetailsLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.savingsAccountDetailsLabel.Location = new System.Drawing.Point(4, 9);
            this.savingsAccountDetailsLabel.Name = "savingsAccountDetailsLabel";
            this.savingsAccountDetailsLabel.Size = new System.Drawing.Size(319, 23);
            this.savingsAccountDetailsLabel.TabIndex = 1;
            this.savingsAccountDetailsLabel.Text = "Details for Account: Savings";
            // 
            // accountCheckingBalanceLabel
            // 
            this.accountCheckingBalanceLabel.AutoSize = true;
            this.accountCheckingBalanceLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCheckingBalanceLabel.Location = new System.Drawing.Point(3, 41);
            this.accountCheckingBalanceLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountCheckingBalanceLabel.Name = "accountCheckingBalanceLabel";
            this.accountCheckingBalanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountCheckingBalanceLabel.Size = new System.Drawing.Size(111, 23);
            this.accountCheckingBalanceLabel.TabIndex = 1;
            this.accountCheckingBalanceLabel.Text = "Balance: ";
            // 
            // accountCheckingDateOpenedLabel
            // 
            this.accountCheckingDateOpenedLabel.AutoSize = true;
            this.accountCheckingDateOpenedLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCheckingDateOpenedLabel.Location = new System.Drawing.Point(3, 67);
            this.accountCheckingDateOpenedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountCheckingDateOpenedLabel.Name = "accountCheckingDateOpenedLabel";
            this.accountCheckingDateOpenedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountCheckingDateOpenedLabel.Size = new System.Drawing.Size(156, 23);
            this.accountCheckingDateOpenedLabel.TabIndex = 2;
            this.accountCheckingDateOpenedLabel.Text = "Date Opened: ";
            // 
            // acountICheckingAPYLabel
            // 
            this.acountICheckingAPYLabel.AutoSize = true;
            this.acountICheckingAPYLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acountICheckingAPYLabel.Location = new System.Drawing.Point(3, 93);
            this.acountICheckingAPYLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.acountICheckingAPYLabel.Name = "acountICheckingAPYLabel";
            this.acountICheckingAPYLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acountICheckingAPYLabel.Size = new System.Drawing.Size(98, 23);
            this.acountICheckingAPYLabel.TabIndex = 3;
            this.acountICheckingAPYLabel.Text = "APY (%):";
            // 
            // accountCheckingBalanceValue
            // 
            this.accountCheckingBalanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountCheckingBalanceValue.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCheckingBalanceValue.Location = new System.Drawing.Point(200, 41);
            this.accountCheckingBalanceValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountCheckingBalanceValue.Name = "accountCheckingBalanceValue";
            this.accountCheckingBalanceValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountCheckingBalanceValue.Size = new System.Drawing.Size(135, 18);
            this.accountCheckingBalanceValue.TabIndex = 4;
            this.accountCheckingBalanceValue.Text = "$0000000.00";
            this.accountCheckingBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountCheckingDateOpened
            // 
            this.accountCheckingDateOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountCheckingDateOpened.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCheckingDateOpened.Location = new System.Drawing.Point(217, 67);
            this.accountCheckingDateOpened.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountCheckingDateOpened.Name = "accountCheckingDateOpened";
            this.accountCheckingDateOpened.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountCheckingDateOpened.Size = new System.Drawing.Size(122, 18);
            this.accountCheckingDateOpened.TabIndex = 5;
            this.accountCheckingDateOpened.Text = "--/--/----";
            this.accountCheckingDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountCheckingAPYValue
            // 
            this.accountCheckingAPYValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountCheckingAPYValue.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCheckingAPYValue.Location = new System.Drawing.Point(246, 93);
            this.accountCheckingAPYValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountCheckingAPYValue.Name = "accountCheckingAPYValue";
            this.accountCheckingAPYValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountCheckingAPYValue.Size = new System.Drawing.Size(89, 18);
            this.accountCheckingAPYValue.TabIndex = 6;
            this.accountCheckingAPYValue.Text = "%00.00";
            this.accountCheckingAPYValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountSavingsAPYValue
            // 
            this.accountSavingsAPYValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountSavingsAPYValue.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsAPYValue.Location = new System.Drawing.Point(246, 95);
            this.accountSavingsAPYValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsAPYValue.Name = "accountSavingsAPYValue";
            this.accountSavingsAPYValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsAPYValue.Size = new System.Drawing.Size(76, 23);
            this.accountSavingsAPYValue.TabIndex = 12;
            this.accountSavingsAPYValue.Text = "%00.00";
            this.accountSavingsAPYValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountSavingsDateOpened
            // 
            this.accountSavingsDateOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountSavingsDateOpened.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsDateOpened.Location = new System.Drawing.Point(207, 69);
            this.accountSavingsDateOpened.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsDateOpened.Name = "accountSavingsDateOpened";
            this.accountSavingsDateOpened.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsDateOpened.Size = new System.Drawing.Size(120, 23);
            this.accountSavingsDateOpened.TabIndex = 11;
            this.accountSavingsDateOpened.Text = "--/--/----";
            this.accountSavingsDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountSavingsBalanceValue
            // 
            this.accountSavingsBalanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountSavingsBalanceValue.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsBalanceValue.Location = new System.Drawing.Point(196, 43);
            this.accountSavingsBalanceValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsBalanceValue.Name = "accountSavingsBalanceValue";
            this.accountSavingsBalanceValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsBalanceValue.Size = new System.Drawing.Size(131, 23);
            this.accountSavingsBalanceValue.TabIndex = 10;
            this.accountSavingsBalanceValue.Text = "$0000000.00";
            this.accountSavingsBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountSavingsAPYLabel
            // 
            this.accountSavingsAPYLabel.AutoSize = true;
            this.accountSavingsAPYLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsAPYLabel.Location = new System.Drawing.Point(4, 95);
            this.accountSavingsAPYLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsAPYLabel.Name = "accountSavingsAPYLabel";
            this.accountSavingsAPYLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsAPYLabel.Size = new System.Drawing.Size(98, 23);
            this.accountSavingsAPYLabel.TabIndex = 9;
            this.accountSavingsAPYLabel.Text = "APY (%):";
            // 
            // accountSavingsDateOpenedLabel
            // 
            this.accountSavingsDateOpenedLabel.AutoSize = true;
            this.accountSavingsDateOpenedLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsDateOpenedLabel.Location = new System.Drawing.Point(4, 69);
            this.accountSavingsDateOpenedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsDateOpenedLabel.Name = "accountSavingsDateOpenedLabel";
            this.accountSavingsDateOpenedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsDateOpenedLabel.Size = new System.Drawing.Size(156, 23);
            this.accountSavingsDateOpenedLabel.TabIndex = 8;
            this.accountSavingsDateOpenedLabel.Text = "Date Opened: ";
            // 
            // accountSavingsBalance
            // 
            this.accountSavingsBalance.AutoSize = true;
            this.accountSavingsBalance.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSavingsBalance.Location = new System.Drawing.Point(4, 43);
            this.accountSavingsBalance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.accountSavingsBalance.Name = "accountSavingsBalance";
            this.accountSavingsBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSavingsBalance.Size = new System.Drawing.Size(111, 23);
            this.accountSavingsBalance.TabIndex = 7;
            this.accountSavingsBalance.Text = "Balance: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // accountLoanDetailsPanel
            // 
            this.accountLoanDetailsPanel.Controls.Add(this.loanInterestRate);
            this.accountLoanDetailsPanel.Controls.Add(this.loanInterestRateLabel);
            this.accountLoanDetailsPanel.Controls.Add(this.loanType);
            this.accountLoanDetailsPanel.Controls.Add(this.loanDateTakenLabel);
            this.accountLoanDetailsPanel.Controls.Add(this.loanBalanceRemainingValue);
            this.accountLoanDetailsPanel.Controls.Add(this.loanTypeLabel);
            this.accountLoanDetailsPanel.Controls.Add(this.loanTakenDate);
            this.accountLoanDetailsPanel.Controls.Add(this.loanBalanceLabel);
            this.accountLoanDetailsPanel.Controls.Add(this.accountDebtLoanLabel);
            this.accountLoanDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this.accountLoanDetailsPanel.Name = "accountLoanDetailsPanel";
            this.accountLoanDetailsPanel.Size = new System.Drawing.Size(428, 204);
            this.accountLoanDetailsPanel.TabIndex = 12;
            // 
            // loanType
            // 
            this.loanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanType.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanType.Location = new System.Drawing.Point(193, 95);
            this.loanType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanType.Name = "loanType";
            this.loanType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanType.Size = new System.Drawing.Size(143, 23);
            this.loanType.TabIndex = 12;
            this.loanType.Text = "Student Loan";
            this.loanType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loanDateTakenLabel
            // 
            this.loanDateTakenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanDateTakenLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDateTakenLabel.Location = new System.Drawing.Point(216, 69);
            this.loanDateTakenLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanDateTakenLabel.Name = "loanDateTakenLabel";
            this.loanDateTakenLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanDateTakenLabel.Size = new System.Drawing.Size(120, 23);
            this.loanDateTakenLabel.TabIndex = 11;
            this.loanDateTakenLabel.Text = "--/--/----";
            this.loanDateTakenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loanBalanceRemainingValue
            // 
            this.loanBalanceRemainingValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanBalanceRemainingValue.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBalanceRemainingValue.Location = new System.Drawing.Point(205, 43);
            this.loanBalanceRemainingValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanBalanceRemainingValue.Name = "loanBalanceRemainingValue";
            this.loanBalanceRemainingValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanBalanceRemainingValue.Size = new System.Drawing.Size(131, 23);
            this.loanBalanceRemainingValue.TabIndex = 10;
            this.loanBalanceRemainingValue.Text = "$0000000.00";
            this.loanBalanceRemainingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loanTakenDate
            // 
            this.loanTakenDate.AutoSize = true;
            this.loanTakenDate.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTakenDate.Location = new System.Drawing.Point(4, 69);
            this.loanTakenDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanTakenDate.Name = "loanTakenDate";
            this.loanTakenDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanTakenDate.Size = new System.Drawing.Size(144, 23);
            this.loanTakenDate.TabIndex = 8;
            this.loanTakenDate.Text = "Date Taken: ";
            // 
            // loanBalanceLabel
            // 
            this.loanBalanceLabel.AutoSize = true;
            this.loanBalanceLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBalanceLabel.Location = new System.Drawing.Point(4, 43);
            this.loanBalanceLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanBalanceLabel.Name = "loanBalanceLabel";
            this.loanBalanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanBalanceLabel.Size = new System.Drawing.Size(200, 23);
            this.loanBalanceLabel.TabIndex = 7;
            this.loanBalanceLabel.Text = "Remaing Balance: ";
            // 
            // accountDebtLoanLabel
            // 
            this.accountDebtLoanLabel.AutoSize = true;
            this.accountDebtLoanLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountDebtLoanLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.accountDebtLoanLabel.Location = new System.Drawing.Point(4, 9);
            this.accountDebtLoanLabel.Name = "accountDebtLoanLabel";
            this.accountDebtLoanLabel.Size = new System.Drawing.Size(286, 23);
            this.accountDebtLoanLabel.TabIndex = 1;
            this.accountDebtLoanLabel.Text = "Details for Account: Loan";
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTypeLabel.Location = new System.Drawing.Point(4, 95);
            this.loanTypeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanTypeLabel.Name = "loanTypeLabel";
            this.loanTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanTypeLabel.Size = new System.Drawing.Size(121, 23);
            this.loanTypeLabel.TabIndex = 9;
            this.loanTypeLabel.Text = "Loan Type:";
            // 
            // loanInterestRate
            // 
            this.loanInterestRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanInterestRate.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInterestRate.Location = new System.Drawing.Point(256, 121);
            this.loanInterestRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanInterestRate.Name = "loanInterestRate";
            this.loanInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanInterestRate.Size = new System.Drawing.Size(76, 23);
            this.loanInterestRate.TabIndex = 14;
            this.loanInterestRate.Text = "%00.00";
            this.loanInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loanInterestRateLabel
            // 
            this.loanInterestRateLabel.AutoSize = true;
            this.loanInterestRateLabel.Font = new System.Drawing.Font("Panic Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInterestRateLabel.Location = new System.Drawing.Point(4, 121);
            this.loanInterestRateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.loanInterestRateLabel.Name = "loanInterestRateLabel";
            this.loanInterestRateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loanInterestRateLabel.Size = new System.Drawing.Size(167, 23);
            this.loanInterestRateLabel.TabIndex = 13;
            this.loanInterestRateLabel.Text = "Interest Rate:";
            // 
            // AccountSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1077, 904);
            this.Controls.Add(this.accountSummaryBasePanel);
            this.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AccountSummaryForm";
            this.Text = "AccountSummaryForm";
            this.accountSummaryBasePanel.ResumeLayout(false);
            this.accountSummaryMenuPanel.ResumeLayout(false);
            this.asMenuHeaderPanel.ResumeLayout(false);
            this.asMenuHeaderPanel.PerformLayout();
            this.accountSummaryContentBasePanel.ResumeLayout(false);
            this.accountSummaryTLPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liabilityDoughnutChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDoughnutChart)).EndInit();
            this.accountSummaryHeaderPanel.ResumeLayout(false);
            this.accountSummaryHeaderPanel.PerformLayout();
            this.assetDetailsPanel.ResumeLayout(false);
            this.checkingAccountDetailsPanel.ResumeLayout(false);
            this.checkingAccountDetailsPanel.PerformLayout();
            this.savingsAccountDetails.ResumeLayout(false);
            this.savingsAccountDetails.PerformLayout();
            this.liabilitiesDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.accountLoanDetailsPanel.ResumeLayout(false);
            this.accountLoanDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel accountSummaryBasePanel;
        public System.Windows.Forms.Panel accountSummaryHeaderPanel;
        private System.Windows.Forms.Label mhAcccountSummaryLabel;
        private System.Windows.Forms.Panel accountSummaryContentBasePanel;
        private System.Windows.Forms.Panel accountSummaryMenuPanel;
        public System.Windows.Forms.TableLayoutPanel accountSummaryTLPanel;
        public System.Windows.Forms.DataVisualization.Charting.Chart liabilityDoughnutChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart assetDoughnutChart;
        private System.Windows.Forms.Panel asMenuHeaderPanel;
        private System.Windows.Forms.Label accountOptionsLabel;
        public System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Panel assetDetailsPanel;
        private System.Windows.Forms.Label savingsAccountDetailsLabel;
        private System.Windows.Forms.Panel checkingAccountDetailsPanel;
        private System.Windows.Forms.Label checkingAccounDetailstLabel;
        private System.Windows.Forms.Panel liabilitiesDetailsPanel;
        private System.Windows.Forms.Label acountICheckingAPYLabel;
        private System.Windows.Forms.Label accountCheckingDateOpenedLabel;
        private System.Windows.Forms.Label accountCheckingBalanceLabel;
        private System.Windows.Forms.Label accountSavingsAPYLabel;
        private System.Windows.Forms.Label accountSavingsDateOpenedLabel;
        private System.Windows.Forms.Label accountSavingsBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel savingsAccountDetails;
        public System.Windows.Forms.Label accountCheckingAPYValue;
        public System.Windows.Forms.Label accountCheckingDateOpened;
        public System.Windows.Forms.Label accountCheckingBalanceValue;
        public System.Windows.Forms.Label accountSavingsAPYValue;
        public System.Windows.Forms.Label accountSavingsDateOpened;
        public System.Windows.Forms.Label accountSavingsBalanceValue;
        public System.Windows.Forms.Panel accountLoanDetailsPanel;
        public System.Windows.Forms.Label loanType;
        public System.Windows.Forms.Label loanDateTakenLabel;
        public System.Windows.Forms.Label loanBalanceRemainingValue;
        private System.Windows.Forms.Label loanTypeLabel;
        private System.Windows.Forms.Label loanTakenDate;
        private System.Windows.Forms.Label loanBalanceLabel;
        private System.Windows.Forms.Label accountDebtLoanLabel;
        public System.Windows.Forms.Label loanInterestRate;
        private System.Windows.Forms.Label loanInterestRateLabel;
    }
}
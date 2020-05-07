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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.accountSummaryBasePanel = new System.Windows.Forms.Panel();
            this.accountSummaryHeaderPanel = new System.Windows.Forms.Panel();
            this.mhAcccountSummaryLabel = new System.Windows.Forms.Label();
            this.accountSummaryContentBasePanel = new System.Windows.Forms.Panel();
            this.accountSummaryMenuPanel = new System.Windows.Forms.Panel();
            this.accountSummaryTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.liabilityDoughnutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.assetDoughnutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.accountOptionsLabel = new System.Windows.Forms.Label();
            this.asMenuHeaderPanel = new System.Windows.Forms.Panel();
            this.accountSummaryBasePanel.SuspendLayout();
            this.accountSummaryHeaderPanel.SuspendLayout();
            this.accountSummaryContentBasePanel.SuspendLayout();
            this.accountSummaryMenuPanel.SuspendLayout();
            this.accountSummaryTLPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liabilityDoughnutChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDoughnutChart)).BeginInit();
            this.asMenuHeaderPanel.SuspendLayout();
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
            // accountSummaryHeaderPanel
            // 
            this.accountSummaryHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.accountSummaryHeaderPanel.Controls.Add(this.mhAcccountSummaryLabel);
            this.accountSummaryHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountSummaryHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.accountSummaryHeaderPanel.Name = "accountSummaryHeaderPanel";
            this.accountSummaryHeaderPanel.Size = new System.Drawing.Size(1077, 48);
            this.accountSummaryHeaderPanel.TabIndex = 1;
            // 
            // mhAcccountSummaryLabel
            // 
            this.mhAcccountSummaryLabel.AutoSize = true;
            this.mhAcccountSummaryLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhAcccountSummaryLabel.Location = new System.Drawing.Point(376, 9);
            this.mhAcccountSummaryLabel.Name = "mhAcccountSummaryLabel";
            this.mhAcccountSummaryLabel.Size = new System.Drawing.Size(267, 33);
            this.mhAcccountSummaryLabel.TabIndex = 0;
            this.mhAcccountSummaryLabel.Text = "Money Hub Accounts";
            // 
            // accountSummaryContentBasePanel
            // 
            this.accountSummaryContentBasePanel.Controls.Add(this.accountSummaryTLPanel);
            this.accountSummaryContentBasePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountSummaryContentBasePanel.Location = new System.Drawing.Point(0, 48);
            this.accountSummaryContentBasePanel.Name = "accountSummaryContentBasePanel";
            this.accountSummaryContentBasePanel.Size = new System.Drawing.Size(881, 856);
            this.accountSummaryContentBasePanel.TabIndex = 2;
            // 
            // accountSummaryMenuPanel
            // 
            this.accountSummaryMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.accountSummaryMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountSummaryMenuPanel.Controls.Add(this.asMenuHeaderPanel);
            this.accountSummaryMenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.accountSummaryMenuPanel.Location = new System.Drawing.Point(887, 48);
            this.accountSummaryMenuPanel.Name = "accountSummaryMenuPanel";
            this.accountSummaryMenuPanel.Size = new System.Drawing.Size(190, 856);
            this.accountSummaryMenuPanel.TabIndex = 3;
            // 
            // accountSummaryTLPanel
            // 
            this.accountSummaryTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.accountSummaryTLPanel.ColumnCount = 2;
            this.accountSummaryTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.51354F));
            this.accountSummaryTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.48646F));
            this.accountSummaryTLPanel.Controls.Add(this.liabilityDoughnutChart, 0, 1);
            this.accountSummaryTLPanel.Controls.Add(this.assetDoughnutChart, 0, 0);
            this.accountSummaryTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountSummaryTLPanel.Location = new System.Drawing.Point(0, 0);
            this.accountSummaryTLPanel.Name = "accountSummaryTLPanel";
            this.accountSummaryTLPanel.RowCount = 2;
            this.accountSummaryTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40849F));
            this.accountSummaryTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.59151F));
            this.accountSummaryTLPanel.Size = new System.Drawing.Size(881, 856);
            this.accountSummaryTLPanel.TabIndex = 2;
            // 
            // liabilityDoughnutChart
            // 
            this.liabilityDoughnutChart.BackColor = System.Drawing.Color.DarkOrange;
            this.liabilityDoughnutChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.liabilityDoughnutChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.liabilityDoughnutChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.liabilityDoughnutChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.liabilityDoughnutChart.ChartAreas.Add(chartArea3);
            this.liabilityDoughnutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.liabilityDoughnutChart.Legends.Add(legend3);
            this.liabilityDoughnutChart.Location = new System.Drawing.Point(5, 418);
            this.liabilityDoughnutChart.Name = "liabilityDoughnutChart";
            this.liabilityDoughnutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.liabilityDoughnutChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series3.BorderColor = System.Drawing.Color.Turquoise;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "Liabilities";
            this.liabilityDoughnutChart.Series.Add(series3);
            this.liabilityDoughnutChart.Size = new System.Drawing.Size(435, 433);
            this.liabilityDoughnutChart.TabIndex = 8;
            this.liabilityDoughnutChart.Text = "Liabilities";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Liabilities";
            title3.Text = "Liabilities (USD)";
            this.liabilityDoughnutChart.Titles.Add(title3);
            // 
            // assetDoughnutChart
            // 
            this.assetDoughnutChart.BackColor = System.Drawing.Color.SeaGreen;
            this.assetDoughnutChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.assetDoughnutChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.assetDoughnutChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.assetDoughnutChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.assetDoughnutChart.ChartAreas.Add(chartArea4);
            this.assetDoughnutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.assetDoughnutChart.Legends.Add(legend4);
            this.assetDoughnutChart.Location = new System.Drawing.Point(5, 5);
            this.assetDoughnutChart.Name = "assetDoughnutChart";
            this.assetDoughnutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.assetDoughnutChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series4.BorderColor = System.Drawing.Color.Turquoise;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Assets";
            this.assetDoughnutChart.Series.Add(series4);
            this.assetDoughnutChart.Size = new System.Drawing.Size(435, 405);
            this.assetDoughnutChart.TabIndex = 7;
            this.assetDoughnutChart.Text = "Assets";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Assets";
            title4.Text = "Assets (USD)";
            this.assetDoughnutChart.Titles.Add(title4);
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
            // asMenuHeaderPanel
            // 
            this.asMenuHeaderPanel.Controls.Add(this.accountOptionsLabel);
            this.asMenuHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.asMenuHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.asMenuHeaderPanel.Name = "asMenuHeaderPanel";
            this.asMenuHeaderPanel.Size = new System.Drawing.Size(186, 46);
            this.asMenuHeaderPanel.TabIndex = 2;
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
            this.accountSummaryHeaderPanel.ResumeLayout(false);
            this.accountSummaryHeaderPanel.PerformLayout();
            this.accountSummaryContentBasePanel.ResumeLayout(false);
            this.accountSummaryMenuPanel.ResumeLayout(false);
            this.accountSummaryTLPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liabilityDoughnutChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetDoughnutChart)).EndInit();
            this.asMenuHeaderPanel.ResumeLayout(false);
            this.asMenuHeaderPanel.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
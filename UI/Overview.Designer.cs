﻿namespace MoneyHub_User_Interface
{
    partial class Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.overviewBasePanel = new System.Windows.Forms.Panel();
            this.overviewHeaderPanel = new System.Windows.Forms.Panel();
            this.accountOverviewLabel = new System.Windows.Forms.Label();
            this.overviewBaseTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.netWorthQuadrant = new System.Windows.Forms.Panel();
            this.chartOptionsPanel = new System.Windows.Forms.Panel();
            this.buttonSeeBreakDown = new System.Windows.Forms.Button();
            this.allTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.threeYearRadioButton = new System.Windows.Forms.RadioButton();
            this.oneYearRadioButton = new System.Windows.Forms.RadioButton();
            this.netWorthHistoryPanel = new System.Windows.Forms.Panel();
            this.netWorthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.netWorthHeaderPanel = new System.Windows.Forms.Panel();
            this.netWorthValue = new System.Windows.Forms.Label();
            this.CurrentNetWorthLabel = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Panel();
            this.viewModeLabel = new System.Windows.Forms.Label();
            this.accountSummaryPanel = new System.Windows.Forms.Panel();
            this.netWorthTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.netWorthstatLabel = new System.Windows.Forms.Label();
            this.netWorthTrackStart = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeElapsedValue = new System.Windows.Forms.Label();
            this.netWorthGrowthLabel = new System.Windows.Forms.Label();
            this.totalNetWorthGrowthValue = new System.Windows.Forms.Label();
            this.AverageYearlyNetWorthGrowthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minNetWorthLabel = new System.Windows.Forms.Label();
            this.maxNetWorthLabel = new System.Windows.Forms.Label();
            this.minNetWorthValue = new System.Windows.Forms.Label();
            this.maxNetWorthValue = new System.Windows.Forms.Label();
            this.overviewBasePanel.SuspendLayout();
            this.overviewHeaderPanel.SuspendLayout();
            this.overviewBaseTLPanel.SuspendLayout();
            this.netWorthQuadrant.SuspendLayout();
            this.chartOptionsPanel.SuspendLayout();
            this.netWorthHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthChart)).BeginInit();
            this.netWorthHeaderPanel.SuspendLayout();
            this.timeElapsedLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewBasePanel
            // 
            this.overviewBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.overviewBasePanel.Controls.Add(this.overviewBaseTLPanel);
            this.overviewBasePanel.Controls.Add(this.overviewHeaderPanel);
            this.overviewBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewBasePanel.Font = new System.Drawing.Font("Oxygen Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBasePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.overviewBasePanel.Location = new System.Drawing.Point(0, 0);
            this.overviewBasePanel.Name = "overviewBasePanel";
            this.overviewBasePanel.Size = new System.Drawing.Size(1077, 904);
            this.overviewBasePanel.TabIndex = 1;
            // 
            // overviewHeaderPanel
            // 
            this.overviewHeaderPanel.Controls.Add(this.accountOverviewLabel);
            this.overviewHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewHeaderPanel.Font = new System.Drawing.Font("Oxygen Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewHeaderPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.overviewHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.overviewHeaderPanel.Name = "overviewHeaderPanel";
            this.overviewHeaderPanel.Size = new System.Drawing.Size(1077, 67);
            this.overviewHeaderPanel.TabIndex = 1;
            // 
            // accountOverviewLabel
            // 
            this.accountOverviewLabel.AutoSize = true;
            this.accountOverviewLabel.Location = new System.Drawing.Point(12, 9);
            this.accountOverviewLabel.Name = "accountOverviewLabel";
            this.accountOverviewLabel.Size = new System.Drawing.Size(396, 50);
            this.accountOverviewLabel.TabIndex = 0;
            this.accountOverviewLabel.Text = "Financial Summary";
            // 
            // overviewBaseTLPanel
            // 
            this.overviewBaseTLPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.overviewBaseTLPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.overviewBaseTLPanel.ColumnCount = 1;
            this.overviewBaseTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89219F));
            this.overviewBaseTLPanel.Controls.Add(this.netWorthQuadrant, 0, 0);
            this.overviewBaseTLPanel.Controls.Add(this.accountSummaryPanel, 0, 1);
            this.overviewBaseTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewBaseTLPanel.Location = new System.Drawing.Point(0, 67);
            this.overviewBaseTLPanel.Name = "overviewBaseTLPanel";
            this.overviewBaseTLPanel.RowCount = 2;
            this.overviewBaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.overviewBaseTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.overviewBaseTLPanel.Size = new System.Drawing.Size(1077, 837);
            this.overviewBaseTLPanel.TabIndex = 0;
            // 
            // netWorthQuadrant
            // 
            this.netWorthQuadrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.netWorthQuadrant.Controls.Add(this.timeElapsedLabel);
            this.netWorthQuadrant.Controls.Add(this.chartOptionsPanel);
            this.netWorthQuadrant.Controls.Add(this.netWorthHistoryPanel);
            this.netWorthQuadrant.Controls.Add(this.netWorthHeaderPanel);
            this.netWorthQuadrant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthQuadrant.Location = new System.Drawing.Point(4, 4);
            this.netWorthQuadrant.Name = "netWorthQuadrant";
            this.netWorthQuadrant.Size = new System.Drawing.Size(1069, 562);
            this.netWorthQuadrant.TabIndex = 1;
            // 
            // chartOptionsPanel
            // 
            this.chartOptionsPanel.Controls.Add(this.buttonSeeBreakDown);
            this.chartOptionsPanel.Controls.Add(this.viewModeLabel);
            this.chartOptionsPanel.Controls.Add(this.allTimeRadioButton);
            this.chartOptionsPanel.Controls.Add(this.threeYearRadioButton);
            this.chartOptionsPanel.Controls.Add(this.oneYearRadioButton);
            this.chartOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartOptionsPanel.Location = new System.Drawing.Point(0, 470);
            this.chartOptionsPanel.Name = "chartOptionsPanel";
            this.chartOptionsPanel.Size = new System.Drawing.Size(1069, 92);
            this.chartOptionsPanel.TabIndex = 3;
            // 
            // buttonSeeBreakDown
            // 
            this.buttonSeeBreakDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSeeBreakDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeBreakDown.Location = new System.Drawing.Point(320, 9);
            this.buttonSeeBreakDown.Name = "buttonSeeBreakDown";
            this.buttonSeeBreakDown.Size = new System.Drawing.Size(343, 58);
            this.buttonSeeBreakDown.TabIndex = 7;
            this.buttonSeeBreakDown.Text = "See Net Worth Breakdown";
            this.buttonSeeBreakDown.UseVisualStyleBackColor = true;
            // 
            // allTimeRadioButton
            // 
            this.allTimeRadioButton.AutoSize = true;
            this.allTimeRadioButton.Checked = true;
            this.allTimeRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTimeRadioButton.Location = new System.Drawing.Point(206, 41);
            this.allTimeRadioButton.Name = "allTimeRadioButton";
            this.allTimeRadioButton.Size = new System.Drawing.Size(108, 26);
            this.allTimeRadioButton.TabIndex = 6;
            this.allTimeRadioButton.TabStop = true;
            this.allTimeRadioButton.Text = "All time";
            this.allTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // threeYearRadioButton
            // 
            this.threeYearRadioButton.AutoSize = true;
            this.threeYearRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeYearRadioButton.Location = new System.Drawing.Point(102, 40);
            this.threeYearRadioButton.Name = "threeYearRadioButton";
            this.threeYearRadioButton.Size = new System.Drawing.Size(98, 26);
            this.threeYearRadioButton.TabIndex = 5;
            this.threeYearRadioButton.Text = "3 Years";
            this.threeYearRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneYearRadioButton
            // 
            this.oneYearRadioButton.AutoSize = true;
            this.oneYearRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneYearRadioButton.Location = new System.Drawing.Point(8, 40);
            this.oneYearRadioButton.Name = "oneYearRadioButton";
            this.oneYearRadioButton.Size = new System.Drawing.Size(88, 26);
            this.oneYearRadioButton.TabIndex = 4;
            this.oneYearRadioButton.Text = "1 Year";
            this.oneYearRadioButton.UseVisualStyleBackColor = true;
            // 
            // netWorthHistoryPanel
            // 
            this.netWorthHistoryPanel.Controls.Add(this.netWorthChart);
            this.netWorthHistoryPanel.Location = new System.Drawing.Point(0, 57);
            this.netWorthHistoryPanel.Name = "netWorthHistoryPanel";
            this.netWorthHistoryPanel.Size = new System.Drawing.Size(828, 413);
            this.netWorthHistoryPanel.TabIndex = 2;
            // 
            // netWorthChart
            // 
            this.netWorthChart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.netWorthChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.netWorthChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.netWorthChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.netWorthChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.netWorthChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.netWorthChart.Legends.Add(legend4);
            this.netWorthChart.Location = new System.Drawing.Point(-1, 0);
            this.netWorthChart.Name = "netWorthChart";
            this.netWorthChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series4.BorderColor = System.Drawing.Color.Turquoise;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "NetWorth";
            this.netWorthChart.Series.Add(series4);
            this.netWorthChart.Size = new System.Drawing.Size(783, 401);
            this.netWorthChart.TabIndex = 0;
            this.netWorthChart.Text = "Net Worth";
            // 
            // netWorthHeaderPanel
            // 
            this.netWorthHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthHeaderPanel.Controls.Add(this.pictureBox1);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthTitleLabel);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthValue);
            this.netWorthHeaderPanel.Controls.Add(this.CurrentNetWorthLabel);
            this.netWorthHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.netWorthHeaderPanel.Name = "netWorthHeaderPanel";
            this.netWorthHeaderPanel.Size = new System.Drawing.Size(1069, 57);
            this.netWorthHeaderPanel.TabIndex = 1;
            // 
            // netWorthValue
            // 
            this.netWorthValue.AutoSize = true;
            this.netWorthValue.Location = new System.Drawing.Point(801, 13);
            this.netWorthValue.Name = "netWorthValue";
            this.netWorthValue.Size = new System.Drawing.Size(103, 28);
            this.netWorthValue.TabIndex = 1;
            this.netWorthValue.Text = "$ -1.00";
            // 
            // CurrentNetWorthLabel
            // 
            this.CurrentNetWorthLabel.AutoSize = true;
            this.CurrentNetWorthLabel.Location = new System.Drawing.Point(555, 13);
            this.CurrentNetWorthLabel.Name = "CurrentNetWorthLabel";
            this.CurrentNetWorthLabel.Size = new System.Drawing.Size(272, 28);
            this.CurrentNetWorthLabel.TabIndex = 0;
            this.CurrentNetWorthLabel.Text = "Current Net Worth:  ";
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeElapsedLabel.Controls.Add(this.maxNetWorthValue);
            this.timeElapsedLabel.Controls.Add(this.minNetWorthValue);
            this.timeElapsedLabel.Controls.Add(this.maxNetWorthLabel);
            this.timeElapsedLabel.Controls.Add(this.minNetWorthLabel);
            this.timeElapsedLabel.Controls.Add(this.label2);
            this.timeElapsedLabel.Controls.Add(this.AverageYearlyNetWorthGrowthLabel);
            this.timeElapsedLabel.Controls.Add(this.totalNetWorthGrowthValue);
            this.timeElapsedLabel.Controls.Add(this.netWorthGrowthLabel);
            this.timeElapsedLabel.Controls.Add(this.timeElapsedValue);
            this.timeElapsedLabel.Controls.Add(this.label1);
            this.timeElapsedLabel.Controls.Add(this.startDateValue);
            this.timeElapsedLabel.Controls.Add(this.netWorthTrackStart);
            this.timeElapsedLabel.Controls.Add(this.netWorthstatLabel);
            this.timeElapsedLabel.Location = new System.Drawing.Point(788, 57);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(278, 414);
            this.timeElapsedLabel.TabIndex = 4;
            // 
            // viewModeLabel
            // 
            this.viewModeLabel.AutoSize = true;
            this.viewModeLabel.Location = new System.Drawing.Point(3, 3);
            this.viewModeLabel.Name = "viewModeLabel";
            this.viewModeLabel.Size = new System.Drawing.Size(194, 28);
            this.viewModeLabel.TabIndex = 2;
            this.viewModeLabel.Text = "View Timeframe";
            // 
            // accountSummaryPanel
            // 
            this.accountSummaryPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.accountSummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountSummaryPanel.Location = new System.Drawing.Point(4, 573);
            this.accountSummaryPanel.Name = "accountSummaryPanel";
            this.accountSummaryPanel.Size = new System.Drawing.Size(1069, 260);
            this.accountSummaryPanel.TabIndex = 2;
            // 
            // netWorthTitleLabel
            // 
            this.netWorthTitleLabel.AutoSize = true;
            this.netWorthTitleLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthTitleLabel.Location = new System.Drawing.Point(16, 13);
            this.netWorthTitleLabel.Name = "netWorthTitleLabel";
            this.netWorthTitleLabel.Size = new System.Drawing.Size(253, 33);
            this.netWorthTitleLabel.TabIndex = 2;
            this.netWorthTitleLabel.Text = "Net Worth History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // netWorthstatLabel
            // 
            this.netWorthstatLabel.AutoSize = true;
            this.netWorthstatLabel.Font = new System.Drawing.Font("Oxygen Mono", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthstatLabel.Location = new System.Drawing.Point(74, 1);
            this.netWorthstatLabel.Name = "netWorthstatLabel";
            this.netWorthstatLabel.Size = new System.Drawing.Size(142, 28);
            this.netWorthstatLabel.TabIndex = 0;
            this.netWorthstatLabel.Text = "Statistics";
            // 
            // netWorthTrackStart
            // 
            this.netWorthTrackStart.AutoSize = true;
            this.netWorthTrackStart.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthTrackStart.Location = new System.Drawing.Point(76, 41);
            this.netWorthTrackStart.Name = "netWorthTrackStart";
            this.netWorthTrackStart.Size = new System.Drawing.Size(96, 18);
            this.netWorthTrackStart.TabIndex = 1;
            this.netWorthTrackStart.Text = "Start Date:";
            // 
            // startDateValue
            // 
            this.startDateValue.AutoSize = true;
            this.startDateValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateValue.Location = new System.Drawing.Point(178, 41);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(72, 18);
            this.startDateValue.TabIndex = 2;
            this.startDateValue.Text = "--/--/--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Elapsed:";
            // 
            // timeElapsedValue
            // 
            this.timeElapsedValue.AutoSize = true;
            this.timeElapsedValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedValue.Location = new System.Drawing.Point(178, 72);
            this.timeElapsedValue.Name = "timeElapsedValue";
            this.timeElapsedValue.Size = new System.Drawing.Size(64, 18);
            this.timeElapsedValue.TabIndex = 4;
            this.timeElapsedValue.Text = "0y, 00m";
            // 
            // netWorthGrowthLabel
            // 
            this.netWorthGrowthLabel.AutoSize = true;
            this.netWorthGrowthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthGrowthLabel.Location = new System.Drawing.Point(-2, 105);
            this.netWorthGrowthLabel.Name = "netWorthGrowthLabel";
            this.netWorthGrowthLabel.Size = new System.Drawing.Size(176, 18);
            this.netWorthGrowthLabel.TabIndex = 5;
            this.netWorthGrowthLabel.Text = "Total Account Growth:";
            // 
            // totalNetWorthGrowthValue
            // 
            this.totalNetWorthGrowthValue.AutoSize = true;
            this.totalNetWorthGrowthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetWorthGrowthValue.Location = new System.Drawing.Point(194, 105);
            this.totalNetWorthGrowthValue.Name = "totalNetWorthGrowthValue";
            this.totalNetWorthGrowthValue.Size = new System.Drawing.Size(48, 18);
            this.totalNetWorthGrowthValue.TabIndex = 6;
            this.totalNetWorthGrowthValue.Text = "$0.00";
            // 
            // AverageYearlyNetWorthGrowthLabel
            // 
            this.AverageYearlyNetWorthGrowthLabel.AutoSize = true;
            this.AverageYearlyNetWorthGrowthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageYearlyNetWorthGrowthLabel.Location = new System.Drawing.Point(14, 137);
            this.AverageYearlyNetWorthGrowthLabel.Name = "AverageYearlyNetWorthGrowthLabel";
            this.AverageYearlyNetWorthGrowthLabel.Size = new System.Drawing.Size(144, 18);
            this.AverageYearlyNetWorthGrowthLabel.TabIndex = 7;
            this.AverageYearlyNetWorthGrowthLabel.Text = "Avg Yearly Gowth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "%00.00 / Year";
            // 
            // minNetWorthLabel
            // 
            this.minNetWorthLabel.AutoSize = true;
            this.minNetWorthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthLabel.Location = new System.Drawing.Point(28, 176);
            this.minNetWorthLabel.Name = "minNetWorthLabel";
            this.minNetWorthLabel.Size = new System.Drawing.Size(152, 18);
            this.minNetWorthLabel.TabIndex = 9;
            this.minNetWorthLabel.Text = "Minnimum Net Worth\r\n";
            // 
            // maxNetWorthLabel
            // 
            this.maxNetWorthLabel.AutoSize = true;
            this.maxNetWorthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthLabel.Location = new System.Drawing.Point(30, 210);
            this.maxNetWorthLabel.Name = "maxNetWorthLabel";
            this.maxNetWorthLabel.Size = new System.Drawing.Size(152, 18);
            this.maxNetWorthLabel.TabIndex = 10;
            this.maxNetWorthLabel.Text = "Maximum Net Worth:";
            // 
            // minNetWorthValue
            // 
            this.minNetWorthValue.AutoSize = true;
            this.minNetWorthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthValue.Location = new System.Drawing.Point(194, 176);
            this.minNetWorthValue.Name = "minNetWorthValue";
            this.minNetWorthValue.Size = new System.Drawing.Size(48, 18);
            this.minNetWorthValue.TabIndex = 11;
            this.minNetWorthValue.Text = "$0.00";
            // 
            // maxNetWorthValue
            // 
            this.maxNetWorthValue.AutoSize = true;
            this.maxNetWorthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthValue.Location = new System.Drawing.Point(194, 210);
            this.maxNetWorthValue.Name = "maxNetWorthValue";
            this.maxNetWorthValue.Size = new System.Drawing.Size(48, 18);
            this.maxNetWorthValue.TabIndex = 12;
            this.maxNetWorthValue.Text = "$0.00";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1077, 904);
            this.Controls.Add(this.overviewBasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overview";
            this.Text = "Overview";
            this.overviewBasePanel.ResumeLayout(false);
            this.overviewHeaderPanel.ResumeLayout(false);
            this.overviewHeaderPanel.PerformLayout();
            this.overviewBaseTLPanel.ResumeLayout(false);
            this.netWorthQuadrant.ResumeLayout(false);
            this.chartOptionsPanel.ResumeLayout(false);
            this.chartOptionsPanel.PerformLayout();
            this.netWorthHistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.netWorthChart)).EndInit();
            this.netWorthHeaderPanel.ResumeLayout(false);
            this.netWorthHeaderPanel.PerformLayout();
            this.timeElapsedLabel.ResumeLayout(false);
            this.timeElapsedLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel overviewBasePanel;
        public System.Windows.Forms.Panel overviewHeaderPanel;
        public System.Windows.Forms.Label accountOverviewLabel;
        public System.Windows.Forms.TableLayoutPanel overviewBaseTLPanel;
        public System.Windows.Forms.Panel netWorthQuadrant;
        private System.Windows.Forms.Panel timeElapsedLabel;
        public System.Windows.Forms.Panel chartOptionsPanel;
        public System.Windows.Forms.Button buttonSeeBreakDown;
        private System.Windows.Forms.Label viewModeLabel;
        public System.Windows.Forms.RadioButton allTimeRadioButton;
        public System.Windows.Forms.RadioButton threeYearRadioButton;
        public System.Windows.Forms.RadioButton oneYearRadioButton;
        private System.Windows.Forms.Panel netWorthHistoryPanel;
        public System.Windows.Forms.DataVisualization.Charting.Chart netWorthChart;
        public System.Windows.Forms.Panel netWorthHeaderPanel;
        public System.Windows.Forms.Label netWorthValue;
        public System.Windows.Forms.Label CurrentNetWorthLabel;
        private System.Windows.Forms.Label netWorthTitleLabel;
        private System.Windows.Forms.Panel accountSummaryPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startDateValue;
        private System.Windows.Forms.Label netWorthTrackStart;
        private System.Windows.Forms.Label netWorthstatLabel;
        private System.Windows.Forms.Label totalNetWorthGrowthValue;
        private System.Windows.Forms.Label netWorthGrowthLabel;
        private System.Windows.Forms.Label timeElapsedValue;
        private System.Windows.Forms.Label maxNetWorthValue;
        private System.Windows.Forms.Label minNetWorthValue;
        private System.Windows.Forms.Label maxNetWorthLabel;
        private System.Windows.Forms.Label minNetWorthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AverageYearlyNetWorthGrowthLabel;
    }
}
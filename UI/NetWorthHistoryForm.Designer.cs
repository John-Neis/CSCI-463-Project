namespace MoneyHub_User_Interface
{
    partial class NetWorthHistoryForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetWorthHistoryForm));
            this.netWorthHistoryBasePanel = new System.Windows.Forms.Panel();
            this.netWorthStatsPanel = new System.Windows.Forms.Panel();
            this.maxNetWorthDateLabel = new System.Windows.Forms.Label();
            this.maxNetWorthDate = new System.Windows.Forms.Label();
            this.minNetWorthDate = new System.Windows.Forms.Label();
            this.minNetWorthDateLabel = new System.Windows.Forms.Label();
            this.maxNetWorthValue = new System.Windows.Forms.Label();
            this.allTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.viewTimeFrameLabel = new System.Windows.Forms.Label();
            this.threeYearRadioButton = new System.Windows.Forms.RadioButton();
            this.minNetWorthValue = new System.Windows.Forms.Label();
            this.oneYearRadioButton = new System.Windows.Forms.RadioButton();
            this.maxNetWorthLabel = new System.Windows.Forms.Label();
            this.minNetWorthLabel = new System.Windows.Forms.Label();
            this.averageGrowthValue = new System.Windows.Forms.Label();
            this.AverageYearlyNetWorthGrowthLabel = new System.Windows.Forms.Label();
            this.totalNetWorthGrowthValue = new System.Windows.Forms.Label();
            this.netWorthGrowthLabel = new System.Windows.Forms.Label();
            this.timeElapsedValue = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.Label();
            this.netWorthTrackStart = new System.Windows.Forms.Label();
            this.netWorthstatLabel = new System.Windows.Forms.Label();
            this.chartOptionsPanel = new System.Windows.Forms.Panel();
            this.buttonSeeBreakDown = new System.Windows.Forms.Button();
            this.netWorthHistoryPanel = new System.Windows.Forms.Panel();
            this.netWorthLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.netWorthHeaderPanel = new System.Windows.Forms.Panel();
            this.netWorthHistoryPB = new System.Windows.Forms.PictureBox();
            this.netWorthHistoryLabel = new System.Windows.Forms.Label();
            this.netWorthValue = new System.Windows.Forms.Label();
            this.CurrentNetWorthLabel = new System.Windows.Forms.Label();
            this.netWorthHistoryBasePanel.SuspendLayout();
            this.netWorthStatsPanel.SuspendLayout();
            this.chartOptionsPanel.SuspendLayout();
            this.netWorthHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthLineChart)).BeginInit();
            this.netWorthHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthHistoryPB)).BeginInit();
            this.SuspendLayout();
            // 
            // netWorthHistoryBasePanel
            // 
            this.netWorthHistoryBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.netWorthHistoryBasePanel.Controls.Add(this.netWorthStatsPanel);
            this.netWorthHistoryBasePanel.Controls.Add(this.chartOptionsPanel);
            this.netWorthHistoryBasePanel.Controls.Add(this.netWorthHistoryPanel);
            this.netWorthHistoryBasePanel.Controls.Add(this.netWorthHeaderPanel);
            this.netWorthHistoryBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthHistoryBasePanel.Location = new System.Drawing.Point(0, 0);
            this.netWorthHistoryBasePanel.Name = "netWorthHistoryBasePanel";
            this.netWorthHistoryBasePanel.Size = new System.Drawing.Size(1069, 552);
            this.netWorthHistoryBasePanel.TabIndex = 2;
            // 
            // netWorthStatsPanel
            // 
            this.netWorthStatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.netWorthStatsPanel.Controls.Add(this.maxNetWorthDateLabel);
            this.netWorthStatsPanel.Controls.Add(this.maxNetWorthDate);
            this.netWorthStatsPanel.Controls.Add(this.minNetWorthDate);
            this.netWorthStatsPanel.Controls.Add(this.minNetWorthDateLabel);
            this.netWorthStatsPanel.Controls.Add(this.maxNetWorthValue);
            this.netWorthStatsPanel.Controls.Add(this.allTimeRadioButton);
            this.netWorthStatsPanel.Controls.Add(this.viewTimeFrameLabel);
            this.netWorthStatsPanel.Controls.Add(this.threeYearRadioButton);
            this.netWorthStatsPanel.Controls.Add(this.minNetWorthValue);
            this.netWorthStatsPanel.Controls.Add(this.oneYearRadioButton);
            this.netWorthStatsPanel.Controls.Add(this.maxNetWorthLabel);
            this.netWorthStatsPanel.Controls.Add(this.minNetWorthLabel);
            this.netWorthStatsPanel.Controls.Add(this.averageGrowthValue);
            this.netWorthStatsPanel.Controls.Add(this.AverageYearlyNetWorthGrowthLabel);
            this.netWorthStatsPanel.Controls.Add(this.totalNetWorthGrowthValue);
            this.netWorthStatsPanel.Controls.Add(this.netWorthGrowthLabel);
            this.netWorthStatsPanel.Controls.Add(this.timeElapsedValue);
            this.netWorthStatsPanel.Controls.Add(this.timeElapsedLabel);
            this.netWorthStatsPanel.Controls.Add(this.startDateValue);
            this.netWorthStatsPanel.Controls.Add(this.netWorthTrackStart);
            this.netWorthStatsPanel.Controls.Add(this.netWorthstatLabel);
            this.netWorthStatsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.netWorthStatsPanel.ForeColor = System.Drawing.Color.SeaGreen;
            this.netWorthStatsPanel.Location = new System.Drawing.Point(759, 57);
            this.netWorthStatsPanel.Name = "netWorthStatsPanel";
            this.netWorthStatsPanel.Size = new System.Drawing.Size(310, 426);
            this.netWorthStatsPanel.TabIndex = 4;
            // 
            // maxNetWorthDateLabel
            // 
            this.maxNetWorthDateLabel.AutoSize = true;
            this.maxNetWorthDateLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthDateLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.maxNetWorthDateLabel.Location = new System.Drawing.Point(2, 250);
            this.maxNetWorthDateLabel.Name = "maxNetWorthDateLabel";
            this.maxNetWorthDateLabel.Size = new System.Drawing.Size(192, 18);
            this.maxNetWorthDateLabel.TabIndex = 16;
            this.maxNetWorthDateLabel.Text = "Date of Max. Net Worth:";
            // 
            // maxNetWorthDate
            // 
            this.maxNetWorthDate.AutoSize = true;
            this.maxNetWorthDate.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthDate.ForeColor = System.Drawing.Color.Honeydew;
            this.maxNetWorthDate.Location = new System.Drawing.Point(213, 250);
            this.maxNetWorthDate.Name = "maxNetWorthDate";
            this.maxNetWorthDate.Size = new System.Drawing.Size(72, 18);
            this.maxNetWorthDate.TabIndex = 15;
            this.maxNetWorthDate.Text = "--/--/--";
            // 
            // minNetWorthDate
            // 
            this.minNetWorthDate.AutoSize = true;
            this.minNetWorthDate.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthDate.ForeColor = System.Drawing.Color.Honeydew;
            this.minNetWorthDate.Location = new System.Drawing.Point(213, 194);
            this.minNetWorthDate.Name = "minNetWorthDate";
            this.minNetWorthDate.Size = new System.Drawing.Size(72, 18);
            this.minNetWorthDate.TabIndex = 14;
            this.minNetWorthDate.Text = "--/--/--";
            // 
            // minNetWorthDateLabel
            // 
            this.minNetWorthDateLabel.AutoSize = true;
            this.minNetWorthDateLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthDateLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.minNetWorthDateLabel.Location = new System.Drawing.Point(2, 194);
            this.minNetWorthDateLabel.Name = "minNetWorthDateLabel";
            this.minNetWorthDateLabel.Size = new System.Drawing.Size(192, 18);
            this.minNetWorthDateLabel.TabIndex = 13;
            this.minNetWorthDateLabel.Text = "Date of Min. Net Worth:";
            // 
            // maxNetWorthValue
            // 
            this.maxNetWorthValue.AutoSize = true;
            this.maxNetWorthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthValue.ForeColor = System.Drawing.Color.Honeydew;
            this.maxNetWorthValue.Location = new System.Drawing.Point(186, 222);
            this.maxNetWorthValue.Name = "maxNetWorthValue";
            this.maxNetWorthValue.Size = new System.Drawing.Size(48, 18);
            this.maxNetWorthValue.TabIndex = 12;
            this.maxNetWorthValue.Text = "$0.00";
            // 
            // allTimeRadioButton
            // 
            this.allTimeRadioButton.AutoSize = true;
            this.allTimeRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTimeRadioButton.ForeColor = System.Drawing.Color.Honeydew;
            this.allTimeRadioButton.Location = new System.Drawing.Point(84, 371);
            this.allTimeRadioButton.Name = "allTimeRadioButton";
            this.allTimeRadioButton.Size = new System.Drawing.Size(108, 26);
            this.allTimeRadioButton.TabIndex = 6;
            this.allTimeRadioButton.Text = "All time";
            this.allTimeRadioButton.UseVisualStyleBackColor = true;
            this.allTimeRadioButton.CheckedChanged += new System.EventHandler(this.allTimeRadioButton_CheckedChanged);
            // 
            // viewTimeFrameLabel
            // 
            this.viewTimeFrameLabel.AutoSize = true;
            this.viewTimeFrameLabel.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTimeFrameLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.viewTimeFrameLabel.Location = new System.Drawing.Point(75, 282);
            this.viewTimeFrameLabel.Name = "viewTimeFrameLabel";
            this.viewTimeFrameLabel.Size = new System.Drawing.Size(150, 22);
            this.viewTimeFrameLabel.TabIndex = 2;
            this.viewTimeFrameLabel.Text = "View Timeframe";
            // 
            // threeYearRadioButton
            // 
            this.threeYearRadioButton.AutoSize = true;
            this.threeYearRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeYearRadioButton.ForeColor = System.Drawing.Color.Honeydew;
            this.threeYearRadioButton.Location = new System.Drawing.Point(84, 339);
            this.threeYearRadioButton.Name = "threeYearRadioButton";
            this.threeYearRadioButton.Size = new System.Drawing.Size(98, 26);
            this.threeYearRadioButton.TabIndex = 5;
            this.threeYearRadioButton.Text = "3 Years";
            this.threeYearRadioButton.UseVisualStyleBackColor = true;
            this.threeYearRadioButton.CheckedChanged += new System.EventHandler(this.threeYearRadioButton_CheckedChanged);
            // 
            // minNetWorthValue
            // 
            this.minNetWorthValue.AutoSize = true;
            this.minNetWorthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthValue.ForeColor = System.Drawing.Color.Honeydew;
            this.minNetWorthValue.Location = new System.Drawing.Point(186, 167);
            this.minNetWorthValue.Name = "minNetWorthValue";
            this.minNetWorthValue.Size = new System.Drawing.Size(48, 18);
            this.minNetWorthValue.TabIndex = 11;
            this.minNetWorthValue.Text = "$0.00";
            // 
            // oneYearRadioButton
            // 
            this.oneYearRadioButton.AutoSize = true;
            this.oneYearRadioButton.Checked = true;
            this.oneYearRadioButton.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneYearRadioButton.ForeColor = System.Drawing.Color.Honeydew;
            this.oneYearRadioButton.Location = new System.Drawing.Point(84, 307);
            this.oneYearRadioButton.Name = "oneYearRadioButton";
            this.oneYearRadioButton.Size = new System.Drawing.Size(88, 26);
            this.oneYearRadioButton.TabIndex = 4;
            this.oneYearRadioButton.TabStop = true;
            this.oneYearRadioButton.Text = "1 Year";
            this.oneYearRadioButton.UseVisualStyleBackColor = true;
            this.oneYearRadioButton.CheckedChanged += new System.EventHandler(this.oneYearRadioButton_CheckedChanged);
            // 
            // maxNetWorthLabel
            // 
            this.maxNetWorthLabel.AutoSize = true;
            this.maxNetWorthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNetWorthLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.maxNetWorthLabel.Location = new System.Drawing.Point(2, 222);
            this.maxNetWorthLabel.Name = "maxNetWorthLabel";
            this.maxNetWorthLabel.Size = new System.Drawing.Size(152, 18);
            this.maxNetWorthLabel.TabIndex = 10;
            this.maxNetWorthLabel.Text = "Maximum Net Worth:";
            // 
            // minNetWorthLabel
            // 
            this.minNetWorthLabel.AutoSize = true;
            this.minNetWorthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNetWorthLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.minNetWorthLabel.Location = new System.Drawing.Point(4, 167);
            this.minNetWorthLabel.Name = "minNetWorthLabel";
            this.minNetWorthLabel.Size = new System.Drawing.Size(160, 18);
            this.minNetWorthLabel.TabIndex = 9;
            this.minNetWorthLabel.Text = "Minnimum Net Worth:\r\n";
            // 
            // averageGrowthValue
            // 
            this.averageGrowthValue.AutoSize = true;
            this.averageGrowthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageGrowthValue.ForeColor = System.Drawing.Color.Honeydew;
            this.averageGrowthValue.Location = new System.Drawing.Point(186, 137);
            this.averageGrowthValue.Name = "averageGrowthValue";
            this.averageGrowthValue.Size = new System.Drawing.Size(88, 18);
            this.averageGrowthValue.TabIndex = 8;
            this.averageGrowthValue.Text = "$000.00/yr";
            // 
            // AverageYearlyNetWorthGrowthLabel
            // 
            this.AverageYearlyNetWorthGrowthLabel.AutoSize = true;
            this.AverageYearlyNetWorthGrowthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageYearlyNetWorthGrowthLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.AverageYearlyNetWorthGrowthLabel.Location = new System.Drawing.Point(4, 137);
            this.AverageYearlyNetWorthGrowthLabel.Name = "AverageYearlyNetWorthGrowthLabel";
            this.AverageYearlyNetWorthGrowthLabel.Size = new System.Drawing.Size(144, 18);
            this.AverageYearlyNetWorthGrowthLabel.TabIndex = 7;
            this.AverageYearlyNetWorthGrowthLabel.Text = "Avg Yearly Gowth:";
            // 
            // totalNetWorthGrowthValue
            // 
            this.totalNetWorthGrowthValue.AutoSize = true;
            this.totalNetWorthGrowthValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetWorthGrowthValue.ForeColor = System.Drawing.Color.Honeydew;
            this.totalNetWorthGrowthValue.Location = new System.Drawing.Point(186, 105);
            this.totalNetWorthGrowthValue.Name = "totalNetWorthGrowthValue";
            this.totalNetWorthGrowthValue.Size = new System.Drawing.Size(48, 18);
            this.totalNetWorthGrowthValue.TabIndex = 6;
            this.totalNetWorthGrowthValue.Text = "$0.00";
            // 
            // netWorthGrowthLabel
            // 
            this.netWorthGrowthLabel.AutoSize = true;
            this.netWorthGrowthLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthGrowthLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.netWorthGrowthLabel.Location = new System.Drawing.Point(4, 105);
            this.netWorthGrowthLabel.Name = "netWorthGrowthLabel";
            this.netWorthGrowthLabel.Size = new System.Drawing.Size(176, 18);
            this.netWorthGrowthLabel.TabIndex = 5;
            this.netWorthGrowthLabel.Text = "Total Account Growth:";
            // 
            // timeElapsedValue
            // 
            this.timeElapsedValue.AutoSize = true;
            this.timeElapsedValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedValue.ForeColor = System.Drawing.Color.Honeydew;
            this.timeElapsedValue.Location = new System.Drawing.Point(148, 72);
            this.timeElapsedValue.Name = "timeElapsedValue";
            this.timeElapsedValue.Size = new System.Drawing.Size(152, 18);
            this.timeElapsedValue.TabIndex = 4;
            this.timeElapsedValue.Text = "0 years, 00 months";
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.timeElapsedLabel.Location = new System.Drawing.Point(4, 72);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(112, 18);
            this.timeElapsedLabel.TabIndex = 3;
            this.timeElapsedLabel.Text = "Time Elapsed:";
            // 
            // startDateValue
            // 
            this.startDateValue.AutoSize = true;
            this.startDateValue.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateValue.ForeColor = System.Drawing.Color.Honeydew;
            this.startDateValue.Location = new System.Drawing.Point(213, 41);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(72, 18);
            this.startDateValue.TabIndex = 2;
            this.startDateValue.Text = "--/--/--";
            // 
            // netWorthTrackStart
            // 
            this.netWorthTrackStart.AutoSize = true;
            this.netWorthTrackStart.Font = new System.Drawing.Font("Oxygen Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthTrackStart.ForeColor = System.Drawing.Color.Honeydew;
            this.netWorthTrackStart.Location = new System.Drawing.Point(4, 41);
            this.netWorthTrackStart.Name = "netWorthTrackStart";
            this.netWorthTrackStart.Size = new System.Drawing.Size(96, 18);
            this.netWorthTrackStart.TabIndex = 1;
            this.netWorthTrackStart.Text = "Start Date:";
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
            // chartOptionsPanel
            // 
            this.chartOptionsPanel.Controls.Add(this.buttonSeeBreakDown);
            this.chartOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartOptionsPanel.Location = new System.Drawing.Point(759, 483);
            this.chartOptionsPanel.Name = "chartOptionsPanel";
            this.chartOptionsPanel.Size = new System.Drawing.Size(310, 69);
            this.chartOptionsPanel.TabIndex = 3;
            // 
            // buttonSeeBreakDown
            // 
            this.buttonSeeBreakDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeeBreakDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSeeBreakDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSeeBreakDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSeeBreakDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeBreakDown.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSeeBreakDown.Location = new System.Drawing.Point(0, 0);
            this.buttonSeeBreakDown.Name = "buttonSeeBreakDown";
            this.buttonSeeBreakDown.Size = new System.Drawing.Size(310, 69);
            this.buttonSeeBreakDown.TabIndex = 7;
            this.buttonSeeBreakDown.Text = "Net Worth Breakdown";
            this.buttonSeeBreakDown.UseVisualStyleBackColor = true;
            this.buttonSeeBreakDown.Click += new System.EventHandler(this.buttonSeeBreakDown_Click);
            // 
            // netWorthHistoryPanel
            // 
            this.netWorthHistoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.netWorthHistoryPanel.Controls.Add(this.netWorthLineChart);
            this.netWorthHistoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.netWorthHistoryPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.netWorthHistoryPanel.Location = new System.Drawing.Point(0, 57);
            this.netWorthHistoryPanel.Name = "netWorthHistoryPanel";
            this.netWorthHistoryPanel.Size = new System.Drawing.Size(759, 495);
            this.netWorthHistoryPanel.TabIndex = 2;
            // 
            // netWorthLineChart
            // 
            this.netWorthLineChart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.netWorthLineChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.netWorthLineChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.netWorthLineChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.netWorthLineChart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.netWorthLineChart.ChartAreas.Add(chartArea4);
            this.netWorthLineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.netWorthLineChart.Legends.Add(legend4);
            this.netWorthLineChart.Location = new System.Drawing.Point(0, 0);
            this.netWorthLineChart.Name = "netWorthLineChart";
            this.netWorthLineChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))))};
            series4.BorderColor = System.Drawing.Color.Turquoise;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "NetWorth";
            this.netWorthLineChart.Series.Add(series4);
            this.netWorthLineChart.Size = new System.Drawing.Size(755, 491);
            this.netWorthLineChart.TabIndex = 0;
            this.netWorthLineChart.Text = "Net Worth";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Net Worth In Dollars";
            title4.Text = "Net Worth (USD)";
            this.netWorthLineChart.Titles.Add(title4);
            // 
            // netWorthHeaderPanel
            // 
            this.netWorthHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthHeaderPanel.Controls.Add(this.netWorthHistoryPB);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthHistoryLabel);
            this.netWorthHeaderPanel.Controls.Add(this.netWorthValue);
            this.netWorthHeaderPanel.Controls.Add(this.CurrentNetWorthLabel);
            this.netWorthHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.netWorthHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.netWorthHeaderPanel.Name = "netWorthHeaderPanel";
            this.netWorthHeaderPanel.Size = new System.Drawing.Size(1069, 57);
            this.netWorthHeaderPanel.TabIndex = 1;
            // 
            // netWorthHistoryPB
            // 
            this.netWorthHistoryPB.Image = ((System.Drawing.Image)(resources.GetObject("netWorthHistoryPB.Image")));
            this.netWorthHistoryPB.Location = new System.Drawing.Point(266, 3);
            this.netWorthHistoryPB.Name = "netWorthHistoryPB";
            this.netWorthHistoryPB.Size = new System.Drawing.Size(60, 49);
            this.netWorthHistoryPB.TabIndex = 1;
            this.netWorthHistoryPB.TabStop = false;
            // 
            // netWorthHistoryLabel
            // 
            this.netWorthHistoryLabel.AutoSize = true;
            this.netWorthHistoryLabel.Font = new System.Drawing.Font("Oxygen Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthHistoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.netWorthHistoryLabel.Location = new System.Drawing.Point(16, 13);
            this.netWorthHistoryLabel.Name = "netWorthHistoryLabel";
            this.netWorthHistoryLabel.Size = new System.Drawing.Size(253, 33);
            this.netWorthHistoryLabel.TabIndex = 2;
            this.netWorthHistoryLabel.Text = "Net Worth History";
            // 
            // netWorthValue
            // 
            this.netWorthValue.AutoSize = true;
            this.netWorthValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.netWorthValue.Location = new System.Drawing.Point(764, 13);
            this.netWorthValue.Name = "netWorthValue";
            this.netWorthValue.Size = new System.Drawing.Size(80, 22);
            this.netWorthValue.TabIndex = 1;
            this.netWorthValue.Text = "$ -1.00";
            // 
            // CurrentNetWorthLabel
            // 
            this.CurrentNetWorthLabel.AutoSize = true;
            this.CurrentNetWorthLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentNetWorthLabel.Location = new System.Drawing.Point(548, 13);
            this.CurrentNetWorthLabel.Name = "CurrentNetWorthLabel";
            this.CurrentNetWorthLabel.Size = new System.Drawing.Size(210, 22);
            this.CurrentNetWorthLabel.TabIndex = 0;
            this.CurrentNetWorthLabel.Text = "Current Net Worth:  ";
            // 
            // NetWorthHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 552);
            this.Controls.Add(this.netWorthHistoryBasePanel);
            this.Font = new System.Drawing.Font("Oxygen Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NetWorthHistoryForm";
            this.Text = "NetWorthHistoryForm";
            this.netWorthHistoryBasePanel.ResumeLayout(false);
            this.netWorthStatsPanel.ResumeLayout(false);
            this.netWorthStatsPanel.PerformLayout();
            this.chartOptionsPanel.ResumeLayout(false);
            this.netWorthHistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.netWorthLineChart)).EndInit();
            this.netWorthHeaderPanel.ResumeLayout(false);
            this.netWorthHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netWorthHistoryPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel netWorthHistoryBasePanel;
        public System.Windows.Forms.Panel netWorthStatsPanel;
        private System.Windows.Forms.Label maxNetWorthDateLabel;
        public System.Windows.Forms.Label maxNetWorthDate;
        public System.Windows.Forms.Label minNetWorthDate;
        private System.Windows.Forms.Label minNetWorthDateLabel;
        public System.Windows.Forms.Label maxNetWorthValue;
        public System.Windows.Forms.RadioButton allTimeRadioButton;
        public System.Windows.Forms.Label viewTimeFrameLabel;
        public System.Windows.Forms.RadioButton threeYearRadioButton;
        public System.Windows.Forms.Label minNetWorthValue;
        public System.Windows.Forms.RadioButton oneYearRadioButton;
        private System.Windows.Forms.Label maxNetWorthLabel;
        private System.Windows.Forms.Label minNetWorthLabel;
        public System.Windows.Forms.Label averageGrowthValue;
        private System.Windows.Forms.Label AverageYearlyNetWorthGrowthLabel;
        public System.Windows.Forms.Label totalNetWorthGrowthValue;
        private System.Windows.Forms.Label netWorthGrowthLabel;
        public System.Windows.Forms.Label timeElapsedValue;
        private System.Windows.Forms.Label timeElapsedLabel;
        public System.Windows.Forms.Label startDateValue;
        private System.Windows.Forms.Label netWorthTrackStart;
        public System.Windows.Forms.Label netWorthstatLabel;
        public System.Windows.Forms.Panel chartOptionsPanel;
        public System.Windows.Forms.Button buttonSeeBreakDown;
        private System.Windows.Forms.Panel netWorthHistoryPanel;
        public System.Windows.Forms.DataVisualization.Charting.Chart netWorthLineChart;
        public System.Windows.Forms.Panel netWorthHeaderPanel;
        private System.Windows.Forms.PictureBox netWorthHistoryPB;
        private System.Windows.Forms.Label netWorthHistoryLabel;
        public System.Windows.Forms.Label netWorthValue;
        public System.Windows.Forms.Label CurrentNetWorthLabel;
    }
}
namespace MyApi
{
    partial class Statistics
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
            chartCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartCities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDates).BeginInit();
            SuspendLayout();
            // 
            // chartCities
            // 
            chartArea1.Name = "ChartArea1";
            chartCities.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCities.Legends.Add(legend1);
            chartCities.Location = new Point(1, 0);
            chartCities.Name = "chartCities";
            chartCities.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Cities";
            series1.YValuesPerPoint = 4;
            chartCities.Series.Add(series1);
            chartCities.Size = new Size(423, 449);
            chartCities.TabIndex = 0;
            chartCities.Text = "chart1";
            title1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title1.Name = "Title";
            title1.Text = "Number of companies per city";
            chartCities.Titles.Add(title1);
            chartCities.Click += chartCities_Click;
            // 
            // chartDates
            // 
            chartArea2.Name = "ChartArea1";
            chartDates.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartDates.Legends.Add(legend2);
            chartDates.Location = new Point(420, 0);
            chartDates.Name = "chartDates";
            chartDates.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerStep = 2;
            series2.Name = "Dates";
            series2.YValuesPerPoint = 4;
            chartDates.Series.Add(series2);
            chartDates.Size = new Size(380, 449);
            chartDates.TabIndex = 1;
            chartDates.Text = "chart1";
            title2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title2.Name = "Title";
            title2.Text = "Number of entries in the database per day";
            chartDates.Titles.Add(title2);
            chartDates.Click += chartDates_Click;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartDates);
            Controls.Add(chartCities);
            Name = "Statistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)chartCities).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCities;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDates;
    }
}
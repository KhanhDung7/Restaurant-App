using Infrastructure.Persistence;
using System.Windows.Forms.DataVisualization.Charting;
namespace thongke
{
    partial class fThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ChartArea chartArea1,chartArea2;

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
            chartArea1 = new ChartArea();
            chartArea2 = new ChartArea();
            Legend legend1 = new Legend();
            Legend legend2 = new Legend();
            this.chart1 = new Chart();
            this.chart2 = new Chart();
            this.chart1.Titles.Add("Doanh thu cửa hàng");
            this.chart2.Titles.Add("Thống kê món ăn");
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.Minimum = 1;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisY.Title = "VND";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            //tao line
            this.chart1.Size = new System.Drawing.Size(1500, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            // 
            // chart2
            // 
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea2";
            chartArea2.AxisY.Title = "Số lượng";
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 450);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(1500, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.ClientSize = new System.Drawing.Size(1550, 800);
            this.ResumeLayout();

        }

        #endregion

        private Chart chart1,chart2;
    }
}
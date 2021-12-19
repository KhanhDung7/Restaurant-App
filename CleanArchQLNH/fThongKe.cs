using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace thongke
{
    public partial class fThongKe : Form
    {
        private string thang;
        private string quy;
        private string nam;
        public fThongKe()
        {
            InitializeComponent();
            
        }
        public void ThongKeThang(string thang,string nam)
        {
            chartArea1.AxisX.Title = "Ngày";
            List<THONGKE> thongkeinfras = ThongKeInfras.Instance.LoadThongKeThang(thang,nam);
            Series series1 = new Series();
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            //series1.Points.Add(new DataPoint(0, 0));
            for (int i = 0; i < thongkeinfras.Count; i++)
            {
                series1.Points.Add(new DataPoint(Int32.Parse(thongkeinfras[i].ThoiGian.Split("/")[0]), (double)(thongkeinfras[i].TongDoanhThu)));
            }
            this.chart1.Series.Add(series1);
            List<THONGKE> thongkemonan = ThongKeInfras.Instance.LoadThongKeMonAnThang(thang,nam);
            for (int i = 0; i < thongkemonan.Count; i++)
            {
                Series series2 = new Series();
                series2.ChartArea = "ChartArea2";
                series2.Label = "" + thongkemonan[i].TongDoanhThu;
                series2.Legend = "Legend2";
                series2.BorderWidth = 10;
                //series2.ChartType = SeriesChartType.Bar;
                series2.Name = thongkemonan[i].ThoiGian;
                series2.Points.Add(new DataPoint(1, (double)thongkemonan[i].TongDoanhThu));
                this.chart2.Series.Add(series2);
            }
        }
        public void ThongKeNam(string nam)
        {
            //doanh thu
            chartArea1.AxisX.Title = "Tháng";
            List<THONGKE> thongkeinfras = ThongKeInfras.Instance.LoadThongKeNam(nam);
            Series series1 = new Series();
            series1.BorderWidth = 3;
            series1.Name = "Doanh thu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            //series1.Points.Add(new DataPoint(0, 0));
            for (int i = 0; i < thongkeinfras.Count; i++)
            {
                DataPoint point = new DataPoint(Int32.Parse(thongkeinfras[i].ThoiGian.Split("/")[0]), (double)thongkeinfras[i].TongDoanhThu);
                series1.Points.Add(point);
            }
            this.chart1.Series.Add(series1);
            //mon an
            List<THONGKE> thongkemonan = ThongKeInfras.Instance.LoadThongKeMonAnNam(nam);
            for(int i = 0; i < thongkemonan.Count; i++)
            {
                Series series2 = new Series();
                series2.ChartArea = "ChartArea2";
                series2.Label = "" + thongkemonan[i].TongDoanhThu;
                series2.Legend = "Legend2";
                series2.BorderWidth = 10;
                series2.Name = thongkemonan[i].ThoiGian;
                series2.Points.Add(new DataPoint(1, (double)thongkemonan[i].TongDoanhThu));
                this.chart2.Series.Add(series2);
            }
        }
        public void ThongKeQuy(string quy,string nam)
        {
            int Quy = Int32.Parse(quy);
            chartArea1.AxisX.Title = "Tháng";
            List<THONGKE> thongkeinfras = ThongKeInfras.Instance.LoadThongKeQuy(Quy,nam);
            Series series1 = new Series();
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            //series1.Points.Add(new DataPoint(0, 0));
            for (int i = 0; i < thongkeinfras.Count; i++)
            {
                series1.Points.Add(new DataPoint(Int32.Parse(thongkeinfras[i].ThoiGian.Split("/")[0]), (double)thongkeinfras[i].TongDoanhThu));
            }
            this.chart1.Series.Add(series1);
            List<THONGKE> thongkemonan = ThongKeInfras.Instance.LoadThongKeMonAnQuy(Quy, nam);
            for (int i = 0; i < thongkemonan.Count; i++)
            {
                Series series2 = new Series();
                series2.ChartArea = "ChartArea2";
                series2.Label = "" + thongkemonan[i].TongDoanhThu;
                series2.Legend = "Legend2";
                //series2.ChartType = SeriesChartType.Bar;
                series2.Name = thongkemonan[i].ThoiGian;
                series2.Points.Add(new DataPoint(1, (double)thongkemonan[i].TongDoanhThu));
                this.chart2.Series.Add(series2);
            }
        }
    }
}

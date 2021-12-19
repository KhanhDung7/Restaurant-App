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

namespace CleanArchQLNH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime date = new DateTime(2019,1,1);
            for(int i = 1; i <= 1778;i++)
            {
                Random random = new Random();
                string mahd = "HD" + i.ToString().PadLeft(8, '0');

                //add HOADON
                string manv = "nv01";
                string makm = "KM1";
                int slk = random.Next(1, 4);
                int tinhtrang = 1;
                decimal tongthanhtoan = decimal.Parse(random.Next(100000, 1500000).ToString());
                string ngaylap = date.ToString("yyyy/MM/dd");
                int maban = random.Next(1, 16);
                HoaDonInfras.Instance.InsertHoaDon(manv, maban, makm, slk, date);
                HoaDonInfras.Instance.CheckOut(mahd, tongthanhtoan, makm);
                date = date.AddDays(1);

                //add CTHD
                string mamon = "MON" + random.Next(1, 10);
                int soluongmon = random.Next(1, 10);
                decimal money = decimal.Parse(random.Next(10000, 300000).ToString());
                CTHDInfras.Instance.InsertCTHD(mahd, maban, mamon, soluongmon, money);
            }
        }
    }
}

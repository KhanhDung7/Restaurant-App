using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Domain.Entities
{
    public class MENU
    {
        private string tenMon;
        private int sLMon;
        private decimal donGia, tongTien;

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SLMon { get => sLMon; set => sLMon = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }

        public MENU(string tenmon, decimal dongia, int slmon, decimal tongtien = 0)
        {
            this.TenMon = tenmon;
            this.DonGia = dongia;
            this.SLMon = slmon;
            this.TongTien = tongtien;
        }

        public MENU(DataRow row)
        {
            this.TenMon = (string)row["TenMon"];
            this.DonGia = (decimal)row["DonGia"];
            this.SLMon = (int)row["SoLuong"];
            this.TongTien = (decimal)row["TongTien"];
        }
    }
}

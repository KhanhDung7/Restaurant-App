using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class THONGKE
    {
        private string thoiGian;
        private decimal tongDoanhThu;

        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public decimal TongDoanhThu { get => tongDoanhThu; set => tongDoanhThu = value; }


        public THONGKE() { }

        public THONGKE(string thoigian, decimal tongdoanhthu)
        {
            this.ThoiGian = thoigian;
            this.TongDoanhThu = tongdoanhthu;
        }

        public THONGKE(DataRow row)
        {
            this.ThoiGian = (string)row["NgayLap"].ToString();
            this.TongDoanhThu = decimal.Parse(row["tongdoanhthu"].ToString());
        }

    }
}
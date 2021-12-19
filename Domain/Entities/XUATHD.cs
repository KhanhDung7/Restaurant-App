using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Domain.Entities
{
    public class XUATHD
    {
        [Key]
        private string manv, tennv, mahd;
        private decimal tongthanhtoan, tienmat, tienthua;
        private int khuyenmai;
        public int Khuyenmai { get { return khuyenmai; } set { khuyenmai = value; } }
        public string Manv { get => manv; set => manv = value; }
        public decimal Tongthanhtoan { get => tongthanhtoan; set => tongthanhtoan = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public decimal Tienmat { get => tienmat; set => tienmat = value; }
        public decimal Tienthua { get => tienthua; set => tienthua = value; }
        public XUATHD(DataRow row)
        {
            this.manv = (string)row["manv"];
            this.mahd = (string)row["mahd"];
            this.tennv = (string)row["hotennv"];
            this.tongthanhtoan = (decimal)row["tongthanhtoan"];
            this.tienmat = (decimal)row["tienkhachdua"];
            this.tienthua = (decimal)row["tienthua"];
            this.khuyenmai = (int)row["phantramKM"];
        }
    }
}

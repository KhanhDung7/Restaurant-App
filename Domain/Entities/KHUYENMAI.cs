 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KHUYENMAI
    {
        private string maKM, tenKM;
        private DateTime ngayBD, ngayKT;
        private int phanTramKM;
        //private Boolean tinhTrang;

        public KHUYENMAI() { }

        public KHUYENMAI(string makm, string tenkm, DateTime ngaybd, DateTime ngaykt, int phantramkm)
        {
            this.MaKM = makm;
            this.TenKM = tenkm;
            this.NgayBD = ngaybd;
            this.NgayKT = ngaykt;
            this.PhanTramKM = phantramkm;
            //this.TinhTrang = true;
        }

        public KHUYENMAI(DataRow row)
        {
            this.MaKM = (string)row["MaKM"];
            this.TenKM = (string)row["TenKM"];
            this.NgayBD = (DateTime)row["NgayBD"];
            this.NgayKT = (DateTime)row["NgayKT"];
            this.PhanTramKM = (int)row["PhanTramKM"];
            //this.TinhTrang = (Boolean)row["TinhTrang"];
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public int PhanTramKM { get => phanTramKM; set => phanTramKM = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CTHD
    {
        private string maHD, maM;
        private int sLMon;
        private decimal tongTien;



        public CTHD(DataRow row)
        {
            this.MaHD = (string)row["MaHD"];
            this.MaM = (string)row["MaM"];
            this.SLMon = (int)row["SL_Mon"];
            this.TongTien = (decimal)row["TongTien"];
        }

        public CTHD(string mahd, string mam, int slmon, decimal tongtien)
        {
            this.MaHD = mahd;
            this.MaM = mam;
            this.SLMon = slmon;
            this.TongTien = tongtien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaM { get => maM; set => maM = value; }
        public int SLMon { get => sLMon; set => sLMon = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}

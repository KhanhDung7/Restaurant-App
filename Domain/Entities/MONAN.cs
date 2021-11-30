using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MONAN
    {
        private string maM, tenM;
        private decimal gia;
        private Boolean tinhTrang;

        public MONAN() 
        {
            this.MaM = "";
            this.TenM = "";
            this.Gia = 0;
            this.TinhTrang = false;
        }

        public MONAN(string mam, string tenm, decimal gia, Boolean tinhtrang)
        {
            this.MaM = mam;
            this.TenM = tenm;
            this.Gia = gia;
            this.TinhTrang = true;
        }

        public MONAN(DataRow row)
        {
            this.MaM = (string)row["MaM"];
            this.TenM = (string)row["TenM"];
            this.Gia = (decimal)row["Gia"];
        }

        public string MaM { get => maM; set => maM = value; }
        public string TenM { get => tenM; set => tenM = value; }
        public decimal Gia { get => gia; set => gia = value   ; }
        public Boolean TinhTrang { get => tinhTrang; set => tinhTrang = value; }

    }
}

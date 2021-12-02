using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Domain.Entities
{
    public class PHIEUDATBAN
    {
        [Key]

        public string MaPDB { get; set; }
        public int MaB { get; set; }
        public string MaKH { get; set; }
        public string SDT_KH { get; set; }
        public DateTime NgayDat { get; set; }
        public string GioDat { get; set; }
        //public bool TinhTrang { get; set; }

        public PHIEUDATBAN(DataRow row)
        {
            this.MaPDB = (string)row["MaPDB"];
            this.MaB = (int)row["MaB"];
            this.MaKH = (string)row["MaKH"];
            this.SDT_KH = (string)row["SDT_KH"];
            this.NgayDat = (DateTime)row["NgayDat"];
            this.GioDat = (string)row["GioDat"];
        }
    }
}

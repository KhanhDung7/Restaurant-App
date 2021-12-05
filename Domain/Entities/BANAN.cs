using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Domain.Entities
{
    public class BANAN
    {

        [Key]
        public int MaB { get; set; }
        public int SoKhach_ToiDa { get; set; }
        public int TinhTrang { get; set; }

        public BANAN(DataRow row)
        {
            this.MaB = (int)row["MaB"];
            this.SoKhach_ToiDa = (int)row["SoKhach_ToiDa"];
            this.TinhTrang = (int)row["TinhTrang"];
        }
    }
}

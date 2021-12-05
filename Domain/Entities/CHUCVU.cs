using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Domain.Entities
{
    public class CHUCVU
    {
        private int maCV;
        private string tenCV;

        public CHUCVU()
        {
            this.MaCV = 1;
            this.TenCV = "";
        }

        public CHUCVU(int macv, string tencv)
        {
            this.MaCV = macv;
            this.TenCV = tencv;
        }

        public CHUCVU(DataRow row)
        {
            this.MaCV = (int)row["MaCV"];
            this.TenCV = (string)row["TenCV"];
        }

        public int MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}

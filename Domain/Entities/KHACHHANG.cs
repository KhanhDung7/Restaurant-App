using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KHACHHANG
    {
        [Key]
        public string HoTenKH { get; set; }
        public string CMND_KH { get; set; }
        public string SDT_KH { get; set; }
        public string Mail_KH { get; set; }
    }
}

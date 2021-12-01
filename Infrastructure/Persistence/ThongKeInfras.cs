using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;

namespace Infrastructure.Persistence
{
    public class ThongKeInfras
    {
        private static ThongKeInfras instance;

        public static ThongKeInfras Instance
        {
            get { if (instance == null) instance = new ThongKeInfras(); return ThongKeInfras.instance; }
            private set { ThongKeInfras.instance = value; }
        }

        private ThongKeInfras() { }

        public static ThongKeUseCase tkuc = new ThongKeUseCase();
        public List<THONGKE> LoadThongKeNgay(string ngay, string thang, string nam)
        {
            return tkuc.LoadThongKeNgay(ngay, thang, nam);
        }

        public List<THONGKE> LoadThongKeThang(string thang, string nam)
        {
            return tkuc.LoadThongKeThang(thang, nam);
        }

        public List<THONGKE> LoadThongKeNam(string nam)
        {
            return tkuc.LoadThongKeNam(nam);
        }


    }
}
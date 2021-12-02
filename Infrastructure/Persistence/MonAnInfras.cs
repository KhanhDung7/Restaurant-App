using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;

namespace Infrastructure.Persistence
{
    public class MonAnInfras
    {
        private static MonAnInfras instance;

        public static MonAnInfras Instance
        {
            get { if (instance == null) instance = new MonAnInfras(); return MonAnInfras.instance; }
            private set { MonAnInfras.instance = value; }
        }

        private MonAnInfras() { }

        public static MonAnUseCase ma = new MonAnUseCase();
        public List<MONAN> LoadFoodList()
        {
            return ma.LoadFoodList();
        }

        public int ThemMonAn(string mam, string tenm, decimal gia)
        {
            return ma.ThemMonAn(mam, tenm, gia);
        }

        public int SuaMonAn(string mam, string tenm,decimal gia)
        {
            return ma.SuaMonAn(mam, tenm, gia);
        }
            
        public int XoaMonAn(string mam)
        {
            return ma.XoaMonAn(mam);
        }
        public List<MONAN> TimMonAn(string noidung)
        {
            return ma.TimMonAn(noidung);
        }
    }
}

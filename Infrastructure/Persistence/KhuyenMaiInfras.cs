using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;

namespace Infrastructure.Persistence
{
    public class KhuyenMaiInfras
    {
        private static KhuyenMaiInfras instance;

        public static KhuyenMaiInfras Instance
        {
            get { if (instance == null) instance = new KhuyenMaiInfras(); return KhuyenMaiInfras.instance; }
            private set { KhuyenMaiInfras.instance = value; }
        }

        private KhuyenMaiInfras() { }

        public static KhuyenMaiUseCase km = new KhuyenMaiUseCase();
        public List<KHUYENMAI> LoadPromotionList()
        {
            return km.LoadPromotionList();
        }
        
        public int ThemKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            return km.ThemKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm);
        }

        public int SuaKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            return km.SuaKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm);
        }

        public int XoaKhuyenMai(string makm)
        {
            return km.XoaKhuyenMai(makm);
        }
        public List<KHUYENMAI> TimKhuyenMai(string noidung)
        {
            return km.TimKhuyenMai(noidung);
        }

       
    }
}

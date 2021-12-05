using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usecase;
using Domain.Entities;
namespace Infrastructure.Persistence
{
    public class PhieuDatBanInfras
    {
        private static PhieuDatBanInfras instance;

        public static PhieuDatBanInfras Instance
        {
            get { if (instance == null) instance = new PhieuDatBanInfras(); return PhieuDatBanInfras.instance; }
            private set { PhieuDatBanInfras.instance = value; }
        }

        private PhieuDatBanInfras() { }

        public PhieuDatBanUseCase pdb = new PhieuDatBanUseCase();
        public List<PHIEUDATBAN> LoadOrderListI()
        {
            return pdb.LoadOrderListUC();
        }
        public int SuaPhieuDatBan(string mapdb, string mab, string makh, string sdt, string ngaydat, string giodat, int tinhtrang)
        {

            return pdb.SuaPhieuDatBan(mapdb, mab, makh, sdt, ngaydat, giodat, tinhtrang);
        }
        public int XoaPhieuDatBan(string mapdb)
        {
            return pdb.XoaPhieuDatBan(mapdb);
        }
        public List<PHIEUDATBAN> TimPhieuDatBan(string noidung)
        {
            return pdb.TimPhieuDatBan(noidung);
        }
    }
}

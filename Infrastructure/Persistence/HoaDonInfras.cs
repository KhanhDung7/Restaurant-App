using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Usecase;

namespace Infrastructure.Persistence
{
    public class HoaDonInfras
    {
        private static HoaDonInfras instance;

        public static HoaDonInfras Instance
        {
            get { if (instance == null) instance = new HoaDonInfras(); return HoaDonInfras.instance; }
            private set { HoaDonInfras.instance = value; }
        }

        private HoaDonInfras() { }

        public static HoaDonUseCase hd = new HoaDonUseCase();

        public string GetUncheckBillIdByTableId(int id)
        {
            return hd.GetUncheckBillIdByTableId(id);
        }

        public int InsertHoaDon(string manv, int mab, string makm, int slkhach)
        {
            return hd.InsertHoaDon(manv, mab, makm, slkhach);
        }

        public string getMaxIdHD()
        {
            return hd.getMaxIdHD();
        }

        public int SuaSLKhachHoaDon(string mahd, int slkhach)
        {
            return hd.SuaSLKhachHoaDon(mahd, slkhach);
        }

        public int SwitchTable(string mahd, int mab)
        {
            return hd.SwitchTable(mahd, mab);
        }

        public int LaySoKhachHD(int id)
        {
            return hd.LaySoKhachHD(id);
        }
        public void CheckOut(string id, decimal tongthanhtoan)
        {
            hd.CheckOut(id, tongthanhtoan);
        }
    }
}

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

        public int InsertHoaDon(string manv, int mab, string makm, int slkhach,DateTime ngaylap)
        {
            return hd.InsertHoaDon(manv, mab, makm, slkhach,ngaylap);
        }
        public int InsertHoaDonGop(string mahd,string manv, int mab, string makm, int slkhach)
        {
            return hd.InsertHoaDonGop(mahd,manv, mab, makm, slkhach);
        }
        public string getMaxIdHD()
        {
            return hd.getMaxIdHD();
        }

        public int SuaSLKhachHoaDon(string mahd,int mab, int slkhach)
        {
            return hd.SuaSLKhachHoaDon(mahd,mab, slkhach);
        }
        public int SuaTienThanhToanHoaDon(string mahd, decimal tienmat, decimal tienthua)
        {
            return hd.SuaTienThanhToanHoaDon(mahd, tienmat,tienthua);
        }
        public int SwitchTable(string mahd,string manv,int bancu, int mab,int slkhach,string makm)
        {
            return hd.SwitchTable(mahd,manv,bancu, mab,slkhach,makm);
        }

        public int LaySoKhachHD(int id)
        {
            return hd.LaySoKhachHD(id);
        }
        public void CheckOut(string id, decimal tongthanhtoan,string makm)
        {
           hd.CheckOut(id, tongthanhtoan,makm);
        }
        public XUATHD LayThongTinHoaDon(string id)
        {
            return hd.LayThongTinHoaDon(id);
        }
    }
}

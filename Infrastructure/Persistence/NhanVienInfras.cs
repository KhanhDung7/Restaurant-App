using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Usecase;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class NhanVienInfras
    {
        private static NhanVienInfras instance;

        public static NhanVienInfras Instance 
        {
            get { if (instance == null) instance = new NhanVienInfras(); return NhanVienInfras.instance; }
            private set { NhanVienInfras.instance = value; }
        }

        private NhanVienInfras() {}

        public static NhanVienUseCase nv =  new NhanVienUseCase();
        public List<NHANVIEN> LoadStaffList()
        {
            return nv.LoadStaffList(); 
        }
        public int ThemNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int chucvu, string matkhau)
        {
            return nv.ThemNhanVien(manv,  hotennv,  cmnd,  sdtnv,  mail,  ngaysinh,  diachi,  hoten_nguoilienhe,  sdt_nguoilienhe, chucvu, matkhau);
        }

        public int SuaNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int chucvu, string matkhau)
        {
            return nv.SuaNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi, hoten_nguoilienhe, sdt_nguoilienhe, chucvu, matkhau);
        }

        public int XoaNhanVien(string manv)
        {
            return nv.XoaNhanVien(manv);
        }

        public List<NHANVIEN> TimNhanVien(string noidung)
        {
            return nv.TimNhanVien(noidung);
        }

    }
}
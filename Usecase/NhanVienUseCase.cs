using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Usecase
{
    public class NhanVienUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<NHANVIEN> LoadStaffList()
        {
            List<NHANVIEN> staffList = new List<NHANVIEN>();
            string query = "Select MaNV, HoTenNV, CMND_NV, SDT_NV, Mail_NV, NgaySinh, DiaChi, HoTen_NguoiLH, SDT_NguoiLH, MaCV, MatKhau" +
                " from NHANVIEN where TinhTrang ='True'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NHANVIEN nv = new NHANVIEN(item);
                staffList.Add(nv);
            }
            return staffList;
        }
        public int ThemNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.NHANVIEN");
            stt = data.Rows.Count + 1;

            string query = "Insert into dbo.NHANVIEN values(";
            query = query + "'nv" + stt + "'";
            query = query + "," + "'" + hotennv + "'";
            query = query + "," + "'" + cmnd + "'";
            query = query + "," + "'" + sdtnv + "'";
            query = query + "," + "'" + mail + "'";
            query = query + "," + "'" + ngaysinh + "'";
            query = query + "," + "'" + diachi + "'";
            query = query + "," + "'" + hoten_nguoilienhe + "'";
            query = query + "," + "'" + sdt_nguoilienhe + "'";
            query = query + "," + "'" + machucvu + "'";
            query = query + "," + "'" + matkhau + "'";
            query = query + "," + "'true'";
            query = query + ")";

            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int SuaNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            string query = "Update dbo.NHANVIEN set ";
            query = query + "HoTenNV=" + "N'" + hotennv + "'";
            query = query + ",CMND_NV=" + "'" + cmnd + "'";
            query = query + ",SDT_NV=" + "'" + sdtnv + "'";
            query = query + ",Mail_NV=" + "'" + mail + "'";
            query = query + ",NgaySinh=" + "'" + ngaysinh + "'";
            query = query + ",DiaChi=" + "N'" + diachi + "'";
            query = query + ",HoTen_NguoiLH=" + "N'" + hoten_nguoilienhe + "'";
            query = query + ",SDT_NguoiLH=" + "'" + sdt_nguoilienhe + "'";
            query = query + ",MaCV=" + machucvu;
            query = query + ",MatKhau=" + "'" + matkhau + "'";
            query = query + ",TinhTrang = 'true'";
            query = query + " " + "where MaNV = '" + manv + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int XoaNhanVien(string manv)
        {
            string query = "Update dbo.NHANVIEN Set ";
            query = query + "TinhTrang= 'False'";
            query = query + " " + "where MaNV = '" + manv + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public List<NHANVIEN> TimNhanVien(string noidung)
        {
            List<NHANVIEN> staffList = new List<NHANVIEN>();
            string query = "Select DISTINCT MaNV, HoTenNV, CMND_NV, SDT_NV, Mail_NV, NgaySinh, DiaChi, HoTen_NguoiLH, SDT_NguoiLH, MaCV, MatKhau" +
                " from NHANVIEN where TinhTrang ='true' AND MaNV LIKE '%" + noidung + "%' OR HoTenNV LIKE '%" + noidung + "%' OR " +
                "CMND_NV LIKE '%" + noidung + "%' OR Mail_NV LIKE '%" + noidung + "%' OR NgaySinh LIKE '%" + noidung + "%' OR " +
                "DiaChi LIKE '%" + noidung + "%' OR HoTen_NguoiLH LIKE '%" + noidung + "%' OR SDT_NguoiLH LIKE '%" + noidung + "%' OR MaCV LIKE '%" + noidung + "%'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NHANVIEN nv = new NHANVIEN(item);
                staffList.Add(nv);
            }
            return staffList;

        }
    }
}

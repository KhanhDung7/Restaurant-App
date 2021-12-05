using System;
using System.Collections;
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
                item[2] = item[2].ToString().Trim();
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

            string query = "Insert into dbo.NHANVIEN values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,1) ;";
            //query = query + "'nv" + stt + "'";
            //query = query + "," + "'" + hotennv + "'";
            //query = query + "," + "'" + cmnd + "'";
            //query = query + "," + "'" + sdtnv + "'";
            //query = query + "," + "'" + mail + "'";
            //query = query + "," + "'" + ngaysinh + "'";
            //query = query + "," + "'" + diachi + "'";
            //query = query + "," + "'" + hoten_nguoilienhe + "'";
            //query = query + "," + "'" + sdt_nguoilienhe + "'";
            //query = query + "," + "'" + machucvu + "'";
            //query = query + "," + "'" + matkhau + "'";
            //query = query + "," + "'true'";
            //query = query + ")";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, "nv"+stt));
            list.Add(new DataTypeSql("@2", SqlDbType.NVarChar, hotennv));
            list.Add(new DataTypeSql("@3", SqlDbType.Char, cmnd));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, sdtnv));
            list.Add(new DataTypeSql("@5", SqlDbType.VarChar, mail));
            list.Add(new DataTypeSql("@6", SqlDbType.Date, ngaysinh));
            list.Add(new DataTypeSql("@7", SqlDbType.NVarChar, diachi));
            list.Add(new DataTypeSql("@8", SqlDbType.NVarChar, hoten_nguoilienhe));
            list.Add(new DataTypeSql("@9", SqlDbType.Char, sdt_nguoilienhe));
            list.Add(new DataTypeSql("@10", SqlDbType.Int, machucvu));
            list.Add(new DataTypeSql("@11", SqlDbType.VarChar, matkhau));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int SuaNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            string query = "Update dbo.NHANVIEN set HoTenNV = @2,CMND_NV = @3,SDT_NV = @4,Mail_NV = @5, NgaySinh = @6,DiaChi = @7,"+
                " HoTen_NguoiLH = @8, SDT_NguoiLH = @9, MaCV = @10,MatKhau = @11,TinhTrang = 1 where MaNV = @1 ;";
            //query = query + "HoTenNV=" + "N'" + hotennv + "'";
            //query = query + ",CMND_NV=" + "'" + cmnd + "'";
            //query = query + ",SDT_NV=" + "'" + sdtnv + "'";
            //query = query + ",Mail_NV=" + "'" + mail + "'";
            //query = query + ",NgaySinh=" + "'" + ngaysinh + "'";
            //query = query + ",DiaChi=" + "N'" + diachi + "'";
            //query = query + ",HoTen_NguoiLH=" + "N'" + hoten_nguoilienhe + "'";
            //query = query + ",SDT_NguoiLH=" + "'" + sdt_nguoilienhe + "'";
            //query = query + ",MaCV=" + machucvu;
            //query = query + ",MatKhau=" + "'" + matkhau + "'";
            //query = query + ",TinhTrang = 'true'";
            //query = query + " " + "where MaNV = '" + manv + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, manv));
            list.Add(new DataTypeSql("@2", SqlDbType.NVarChar, hotennv));
            list.Add(new DataTypeSql("@3", SqlDbType.Char, cmnd));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, sdtnv));
            list.Add(new DataTypeSql("@5", SqlDbType.VarChar, mail));
            DateTime myDate = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
            list.Add(new DataTypeSql("@6", SqlDbType.Date, myDate));
            list.Add(new DataTypeSql("@7", SqlDbType.NVarChar, diachi));
            list.Add(new DataTypeSql("@8", SqlDbType.NVarChar, hoten_nguoilienhe));
            list.Add(new DataTypeSql("@9", SqlDbType.Char, sdt_nguoilienhe));
            list.Add(new DataTypeSql("@10", SqlDbType.Int, machucvu));
            list.Add(new DataTypeSql("@11", SqlDbType.VarChar, matkhau));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int XoaNhanVien(string manv)
        {
            string query = "Update dbo.NHANVIEN Set TinhTrang = 0 where MaNV = @1 ;";
            //query = query + "TinhTrang= 'False'";
            //query = query + " " + "where MaNV = '" + manv + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, manv));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public List<NHANVIEN> TimNhanVien(string noidung)
        {
            List<NHANVIEN> staffList = new List<NHANVIEN>();
            string query = "Select DISTINCT MaNV, HoTenNV, CMND_NV, SDT_NV, Mail_NV, NgaySinh, DiaChi, HoTen_NguoiLH, SDT_NguoiLH, MaCV, MatKhau" +
                " from NHANVIEN where TinhTrang ='true' AND (MaNV LIKE '%" + noidung + "%' OR HoTenNV LIKE '%" + noidung + "%' OR " +
                "CMND_NV LIKE '%" + noidung + "%' OR Mail_NV LIKE '%" + noidung + "%' OR NgaySinh LIKE '%" + noidung + "%' OR " +
                "DiaChi LIKE '%" + noidung + "%' OR HoTen_NguoiLH LIKE '%" + noidung + "%' OR SDT_NguoiLH LIKE '%" + noidung + "%' OR MaCV LIKE '%" + noidung + "%')";
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

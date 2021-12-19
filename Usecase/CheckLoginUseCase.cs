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
    public class CheckLoginUseCase
    {
        private DataProvider provider = new DataProvider();

        public int Login(string username, string password)
        {
            string query = "Select * from dbo.NHANVIEN where MaNV = @1 AND MatKhau = @2 and tinhtrang=1 ;";

            List<DataTypeSql> arlist1 = new List<DataTypeSql>();
            DataTypeSql data = new DataTypeSql("@1", SqlDbType.Char, username);
            arlist1.Add(data);
            DataTypeSql data1 = new DataTypeSql("@2", SqlDbType.VarChar, password);
            arlist1.Add(data1);
            DataTable result = provider.ExecuteQueryLogin(query, arlist1);

            return result.Rows.Count; //nếu số dòng tìm được =1 thì đúng cho đăng nhập

        }

        //Lấy 1 nhân viên để kiểm tra chức vụ
        public NHANVIEN GetNhanVienByMaNV(string manv)
        {
            DataTable data = provider.ExecuteQuery("select manv,hotennv,cmnd_nv,sdt_nv,Mail_nv,ngaysinh,diachi,hoten_nguoilh,sdt_nguoilh,nhanvien.macv,matkhau,tinhtrang,chucvu.tencv from nhanvien,chucvu where nhanvien.macv=chucvu.macv and MANV = '" + manv + "'");
            foreach(DataRow item in data.Rows)
            {
                return new NHANVIEN(item);
            }

            return null;
        }
    }
}

using System;
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
            string query = "Select * from dbo.NHANVIEN where MaNV = '" + username + "' AND MatKhau = '" + password + "'";
            
            DataTable result = provider.ExecuteQuery(query);

            return result.Rows.Count; //nếu số dòng tìm được =1 thì đúng cho đăng nhập

        }

        //Lấy 1 nhân viên để kiểm tra chức vụ
        /*public NHANVIEN GetNhanVienByMaNV(string manv)
        {
            DataTable data = provider.ExecuteQuery("Select * from dbo.NHANVIEN where MANV = '" + manv + "'");
            foreach(DataRow item in data.Rows)
            {
                return new NHANVIEN(item);
            }

            return null;
        }*/
    }
}

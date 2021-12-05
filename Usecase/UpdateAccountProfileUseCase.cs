using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Usecase
{
    public class UpdateAccountProfileUseCase
    {
        private DataProvider provider = new DataProvider();
        
        public int UpdateAccountProfile(string manv, string hotennv, string cmnd, string sdtnv, string diachi, string chucvu, string matkhau)
        {
            string query = "Update dbo.NHANVIEN set HoTenNV = @1, CMND_NV= @2, SDT_NV = @3,DiaChi = @4,MatKhau = @5 where MaNV =@6 ;";
            //query = query + "HoTenNV=" + "N'" + hotennv + "'";
            //query = query + ",CMND_NV=" + "'" + cmnd + "'";
            //query = query + ",SDT_NV=" + "'" + sdtnv + "'";
            //query = query + ",DiaChi=" + "N'" + diachi + "'";
            //query = query + ",MatKhau=" + "'" + matkhau + "'";
            //query = query + " " + "where MaNV = '" + manv + "'";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1",SqlDbType.NVarChar,hotennv));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, cmnd));
            list.Add(new DataTypeSql("@3", SqlDbType.Char, sdtnv));
            list.Add(new DataTypeSql("@4", SqlDbType.NVarChar, diachi));
            list.Add(new DataTypeSql("@5", SqlDbType.VarChar, matkhau));
            list.Add(new DataTypeSql("@6", SqlDbType.Char, manv));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }
    }
}

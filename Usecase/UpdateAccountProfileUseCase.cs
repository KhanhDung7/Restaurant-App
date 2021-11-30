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
            string query = "Update dbo.NHANVIEN set ";
            query = query + "HoTenNV=" + "N'" + hotennv + "'";
            query = query + ",CMND_NV=" + "'" + cmnd + "'";
            query = query + ",SDT_NV=" + "'" + sdtnv + "'";
            query = query + ",DiaChi=" + "N'" + diachi + "'";
            query = query + ",MatKhau=" + "'" + matkhau + "'";
            query = query + " " + "where MaNV = '" + manv + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }
    }
}

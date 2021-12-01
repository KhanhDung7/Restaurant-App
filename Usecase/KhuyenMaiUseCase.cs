using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usecase
{
    public class KhuyenMaiUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<KHUYENMAI> LoadPromotionList()
        {
            List<KHUYENMAI> promotionList = new List<KHUYENMAI>();
            string query = "Select MaKM, TenKM, NgayBD, NgayKT, PhanTramKM from dbo.KHUYENMAI where TinhTrang = 'true'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KHUYENMAI km = new KHUYENMAI(item);
                promotionList.Add(km);
            }
            return promotionList;
        }

        public int ThemKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.KHUYENMAI");
            stt = data.Rows.Count + 1;
            string query = "Insert into dbo.KHUYENMAI values(";
            query = query + "'KM" + stt + "'";
            query = query + "," + "'" + tenkm + "'";
            query = query + "," + "'" + ngaybd + "'";
            query = query + "," + "'" + ngaykt + "'";
            query = query + "," + "'" + phantramkm + "'";
            query = query + ",'true'";
            query = query + ")";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int SuaKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            string query = "Update dbo.KHUYENMAI set ";
            query = query + "TenKM=" + "'" + tenkm + "'";
            query = query + ",NgayBD=" + "'" + ngaybd + "'";
            query = query + ",NgayKT=" + "'" + ngaykt + "'";
            query = query + ",PhanTramKM=" + "'" + phantramkm + "'";
            query = query + " " + "where MaKM = '" + makm + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int XoaKhuyenMai(string makm)
        {
            string query = "Update dbo.KHUYENMAI Set ";
            query = query + "TinhTrang= 'False'";
            query = query + " " + "where MaKM = '" + makm + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }
        public List<KHUYENMAI> TimKhuyenMai(string noidung)
        {
            List<KHUYENMAI> promotionList = new List<KHUYENMAI>();
            string query = "Select MaKM, TenKM, NgayBD, NgayKT, PhanTramKM from dbo.KHUYENMAI where TinhTrang = 'true' AND (" +
                "MaKM LIKE '%" + noidung + "%' OR TenKM LIKE '%" + noidung + "%' OR NgayBD LIKE '%" + noidung + "%' OR NgayKT LIKE '%" + noidung + "%' OR " +
                "PhanTramKM LIKE '%" + noidung + "%')";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KHUYENMAI km = new KHUYENMAI(item);
                promotionList.Add(km);
            }
            return promotionList;
        }

    }
}

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
            string query = "Insert into dbo.KHUYENMAI values(@1,@2,@3,@4,@5,1)";
            //query = query + "'KM" + stt + "'";
            //query = query + "," + "'" + tenkm + "'";
            //query = query + "," + "'" + ngaybd + "'";
            //query = query + "," + "'" + ngaykt + "'";
            //query = query + "," + "'" + phantramkm + "'";
            //query = query + ",'true'";
            //query = query + ")";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, "KM"+stt));
            list.Add(new DataTypeSql("@2", SqlDbType.NVarChar, tenkm));
            list.Add(new DataTypeSql("@3", SqlDbType.Date, ngaybd));
            list.Add(new DataTypeSql("@4", SqlDbType.Date, ngaykt));
            list.Add(new DataTypeSql("@5", SqlDbType.Int, phantramkm));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int SuaKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            string query = "Update dbo.KHUYENMAI set TenKM = @1, NgayBD = @2, NgayKT = @3, PhanTramKM = @4 where MaKM = @5 ;";
            //query = query + "TenKM=" + "'" + tenkm + "'";
            //query = query + ",NgayBD=" + "'" + ngaybd + "'";
            //query = query + ",NgayKT=" + "'" + ngaykt + "'";
            //query = query + ",PhanTramKM=" + "'" + phantramkm + "'";
            //query = query + " " + "where MaKM = '" + makm + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.NVarChar, tenkm));
            list.Add(new DataTypeSql("@2", SqlDbType.Date, ngaybd));
            list.Add(new DataTypeSql("@3", SqlDbType.Date, ngaykt));
            list.Add(new DataTypeSql("@4", SqlDbType.Int, phantramkm));
            list.Add(new DataTypeSql("@5", SqlDbType.Char, makm));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int XoaKhuyenMai(string makm)
        {
            string query = "Update dbo.KHUYENMAI Set TinhTrang=0 where MaKM = @1 ;";
            //query = query + "TinhTrang= 'False'";
            //query = query + " " + "where MaKM = '" + makm + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, makm));
            int result = provider.ExecuteNonQuery(query, list);
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

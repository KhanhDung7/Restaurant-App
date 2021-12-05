using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usecase
{
    public class MonAnUseCase
    {

        private DataProvider provider = new DataProvider();
        public List<MONAN> LoadFoodList()
        {
            List<MONAN> foodList = new List<MONAN>();
            string query = "Select MaM, TenM, Gia from dbo.MONAN where TinhTrang = 'true'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item["GIA"] = item["GIA"].ToString().Split(".")[0];
                MONAN ma = new MONAN(item);
                foodList.Add(ma);
            }
            return foodList;
        }

        public int ThemMonAn(string mam, string tenm, decimal gia)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.MONAN");
            stt = data.Rows.Count + 1;
            string query = "Insert into dbo.MONAN values(@1,@2,@3,1) ;";
            //query = query + "'mon" + stt + "'";
            //query = query + "," + "'" + tenm + "'";
            //query = query + "," + gia;
            //query = query + ", 'true')";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, "mon"+stt));
            list.Add(new DataTypeSql("@2", SqlDbType.NVarChar, tenm));
            list.Add(new DataTypeSql("@3", SqlDbType.Money, gia));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int SuaMonAn(string mam, string tenm, decimal gia)
        {
            string query = "Update dbo.MONAN set Gia = @1 where MaM = @2 and TENM = @3 ;";
           // query = query + "TenM=" + "'" + tenm + "'";
           // query = query + ",Gia=" + "" + gia + "";

            //query = query + " Gia=" + "" + gia + "";
            //query = query + " " + "where MaM = '" + mam + "' AND TENM= '" + tenm +"'";

            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Money, gia));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mam));
            list.Add(new DataTypeSql("@3", SqlDbType.NVarChar, tenm));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int XoaMonAn(string mam)
        {
            string query = "Update dbo.MONAN Set TinhTrang = 0 where MaM = @1 ;";
            //query = query + "TinhTrang= 'False'";
            //query = query + " " + "where MaM = '" + mam + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mam));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }
        public List<MONAN> TimMonAn(string noidung)
        {
            List<MONAN> foodList = new List<MONAN>();
            string query = "Select MaM, TenM, Gia from dbo.MONAN where TinhTrang = 1 AND (MaM LIKE '%" + noidung + "%' " +
                "OR TenM LIKE '%" + noidung + "%' OR Gia LIKE '%" + noidung + "%')";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item["GIA"] = item["GIA"].ToString().Split(".")[0];
                MONAN ma = new MONAN(item);
                foodList.Add(ma);
            }
            return foodList;
        }
    }
}

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
            string query = "Insert into dbo.MONAN values(";
            query = query + "'mon" + stt + "'";
            query = query + "," + "'" + tenm + "'";
            query = query + "," + gia;
            query = query + ", 'true')";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int SuaMonAn(string mam, string tenm, decimal gia)
        {
            string query = "Update dbo.MONAN set ";
           // query = query + "TenM=" + "'" + tenm + "'";
           // query = query + ",Gia=" + "" + gia + "";
            query = query + " Gia=" + "" + gia + "";
            query = query + " " + "where MaM = '" + mam + "' AND TENM= '" + tenm +"'";

            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int XoaMonAn(string mam)
        {
            string query = "Update dbo.MONAN Set ";
            query = query + "TinhTrang= 'False'";
            query = query + " " + "where MaM = '" + mam + "'";
            int result = provider.ExecuteNonQuery(query);
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

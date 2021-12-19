using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Domain.Entities;
namespace Usecase
{
    public class BanAnUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<BANAN> LoadTableListUC()
        {
            List<BANAN> tableList = new List<BANAN>();
            string query = "SELECT * FROM BANAN";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BANAN table = new BANAN(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public int SuaBanAn(int mab, int sokhach_toida, int tinhtrang)
        {
            string query = "UPDATE BANAN SET SoKhach_ToiDa = @1, TinhTrang = @2 where MaB=@3 ;";
            //query += "SoKhach_ToiDa=" + sokhach_toida + ", ";
            //query += "TinhTrang=" + tinhtrang + " ";
            //query += "WHERE MaB=" + mab;
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, sokhach_toida));
            list.Add(new DataTypeSql("@2", SqlDbType.Int, tinhtrang));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }

        public int SwitchTable(int mab, int tinhtrang)
        {
            string query = "UPDATE BANAN SET TinhTrang=@1 where MaB = @2 ;";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, tinhtrang));
            list.Add(new DataTypeSql("@2", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }

        public int LaySoKhachToiDa(int id)
        {
            string query = "Select * from dbo.BANAN";
            query = query + " where MaB = "+id;
            DataTable data = provider.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                BANAN ba = new BANAN(data.Rows[0]);
                return ba.SoKhach_ToiDa;
            }
            else
            {
                return -1;
            }
        }

        public List<BANAN> TimBanAn(string noidung)
        {
            List<BANAN> tableList = new List<BANAN>();
            string query = "SELECT * FROM BANAN WHERE MaB='"+noidung+"' OR SoKhach_ToiDa= '"+noidung+"'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BANAN table = new BANAN(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<BANAN> LoadTableList()
        {
            List<BANAN> tableList = new List<BANAN>();
            string query = "SELECT * FROM BANAN WHERE TinhTrang=1";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BANAN table = new BANAN(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}

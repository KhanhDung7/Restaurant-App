using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;

namespace Usecase
{
    public class CTHDUseCase
    {
        private DataProvider provider = new DataProvider();

        public List<CTHD> GetListCTHD(string id)
        {
            List<CTHD> listCTHD = new List<CTHD>();
            string query = "Select * from dbo.CTHD";
            query = query + " where MaHD = '" + id + "'";
            List<DataTypeSql> list = new List<DataTypeSql>();
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                CTHD cthd = new CTHD(item);
                listCTHD.Add(cthd);
            }
            return listCTHD;
        }

        public int InsertCTHD(string mahd,int mab, string mam, int slmon, decimal tongtien)
        {
            string query = "Insert into dbo.CTHD values(@1,@5,@2,@3,@4);";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mam));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, slmon));
            list.Add(new DataTypeSql("@4", SqlDbType.Money, tongtien));
            list.Add(new DataTypeSql("@5", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }

        public int UpdateSLMonCTHD(string mahd,int mab, string mam, int slmon, decimal tongtien)
        {
            string query = "Update dbo.CTHD set SL_mon = @1,TongTien = @2 where MaHD = @3 and MaB=@5 and MaM = @4 ;";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, slmon));
            list.Add(new DataTypeSql("@2", SqlDbType.Money, tongtien));
            list.Add(new DataTypeSql("@3", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, mam));
            list.Add(new DataTypeSql("@5", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }

        public int DeleteCTHD(string mahd, string mam, int mab)
        {
            string query = "DELETE dbo.CTHD WHERE MaHD= @1 and MaM = @2 and MaB=@3 ;";
            //query = query + " AND MaM= '" + mam + "'";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mam));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }

    }
}

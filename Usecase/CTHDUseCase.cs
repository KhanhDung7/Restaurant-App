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
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTHD cthd = new CTHD(item);
                listCTHD.Add(cthd);
            }
            return listCTHD;
        }

        public int InsertCTHD(string mahd, string mam, int slmon, decimal tongtien)
        {
            string query = "Insert into dbo.CTHD values(";
            query = query + "'" + mahd + "'";
            query = query + "," + "'" + mam + "'";
            query = query + "," + " " + slmon;
            query = query + "," + " " + tongtien;
            query = query + ")";

            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int UpdateSLMonCTHD(string mahd, string mam, int slmon, decimal tongtien)
        {
            string query = "Update dbo.CTHD set ";
            query = query + "SL_Mon= " + slmon + " ";
            query = query + ",TongTien= " + tongtien + " ";
            query = query + "Where MaHD= " + "'" + mahd + "' ";
            query = query + "And MaM= " + "'" + mam + "'";

            int result = provider.ExecuteNonQuery(query);
            return result;
        }

        public int DeleteCTHD(string mahd, string mam)
        {
            string query = "DELETE dbo.CTHD WHERE MaHD='" + mahd + "'";
            query = query + " AND MaM= '" + mam + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }
    }
}

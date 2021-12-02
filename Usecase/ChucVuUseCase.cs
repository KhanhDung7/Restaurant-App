using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;

namespace Usecase
{
    public class ChucVuUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<CHUCVU> LoadDSChucVu()
        {
            List<CHUCVU> positionList = new List<CHUCVU>();
            string query = "Select * from dbo.CHUCVU";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CHUCVU cv = new CHUCVU(item);
                positionList.Add(cv);
            }
            return positionList;
        }
    }
}

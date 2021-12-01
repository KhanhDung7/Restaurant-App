using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;

namespace Usecase
{
    public class MenuUseCase
    {
        public DataProvider provider = new DataProvider();

        public List<MENU> GetListMenuByTable(int id)
        {
            List<MENU> listMenu = new List<MENU>();
            string query = "select MONAN.TenM as TenMon, MONAN.Gia as DonGia, CTHD.SL_Mon as SoLuong, CTHD.SL_Mon*MONAN.Gia as TongTien";
            query = query + " From dbo.HOADON, dbo.CTHD, dbo.MONAN";
            query = query + " where CTHD.MaHD = HOADON.MaHD and CTHD.MaM = MONAN.MaM and HOADON.TinhTrang = 'false' and HOADON.MaB = " + id;
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MENU menu = new MENU(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

    }
}

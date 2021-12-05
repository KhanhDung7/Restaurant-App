using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;
namespace Usecase
{
    public class PhieuDatBanUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<PHIEUDATBAN> LoadOrderListUC()
        {
            List<PHIEUDATBAN> orderList = new List<PHIEUDATBAN>();
            string query = "SELECT MaPDB, MaB, PDB.MaKH, SDT_KH, NgayDat, GioDat FROM PHIEUDATBAN AS PDB, KHACHHANG AS KH WHERE TinhTrang='false' AND PDB.MAKH=KH.MAKH";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PHIEUDATBAN pdb = new PHIEUDATBAN(item);
                orderList.Add(pdb);
            }
            return orderList;
        }
        public int SuaPhieuDatBan(string mapdb, string mab, string makh, string sdt, string ngaydat, string giodat, int tinhtrang)
        {
            string query = "UPDATE PHIEUDATBAN SET MaB = @1, MaKH = @2,NgayDat = @3,GioDat = @4,TinhTrang = @5 where MaPDB = @6 ;";
            //query += "MaB=" + int.Parse(mab) + ", ";
            //query += "MaKH='" + makh + "', ";
            //query += "NgayDat='" + ngaydat + "', ";
            //query += "GioDat='" + giodat + "', ";
            //query += "TinhTrang='" + tinhtrang + "' ";
            //query += "WHERE MaPDB='" + mapdb + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, mab));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, makh));
            list.Add(new DataTypeSql("@3", SqlDbType.Date, ngaydat));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, giodat));
            list.Add(new DataTypeSql("@5", SqlDbType.Bit, tinhtrang));
            list.Add(new DataTypeSql("@6", SqlDbType.Char, mapdb));
            int result = provider.ExecuteNonQuery(query, list);
            if (result == 1)
            {
                query = "UPDATE KHACHHANG SET SDT_KH = @1 where MaKH = @2 ;";
                //query += "SDT_KH='" + sdt + "' WHERE MaKH='" + makh + "'";
                //result = provider.ExecuteNonQuery(query);
                list = new List<DataTypeSql>();
                list.Add(new DataTypeSql("@1", SqlDbType.Char, sdt));
                list.Add(new DataTypeSql("@2", SqlDbType.Char, makh));
                result = provider.ExecuteNonQuery(query, list);
            }
            return result;
        }
        public int XoaPhieuDatBan(string mapdb)
        {
            string query = "DELETE PHIEUDATBAN WHERE MaPDB= @1 ;";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mapdb));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }
        public List<PHIEUDATBAN> TimPhieuDatBan(string noidung)
        {
            List<PHIEUDATBAN> orderList = new List<PHIEUDATBAN>();
            string query = "SELECT DISTINCT MaPDB, MaB, PDB.MaKH, SDT_KH, NgayDat, GioDat FROM PHIEUDATBAN AS PDB, KHACHHANG AS KH" +
                " WHERE TinhTrang = 'false' AND (MaPDB LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH OR MaB LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH  OR PDB.MaKH LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH" +
                " OR TinhTrang = 'false' AND NgayDat LIKE '%" + noidung.Replace('/', '-') + "%' AND PDB.MaKH = KH.MaKH OR TinhTrang = 'false' AND GioDat LIKE '%" + noidung + "%'" +
                " AND PDB.MaKH = KH.MaKH OR TinhTrang = 'false' AND SDT_KH LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH)";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PHIEUDATBAN pdb = new PHIEUDATBAN(item);
                orderList.Add(pdb);
            }
            return orderList;
        }
    }
}

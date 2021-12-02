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
        public int SuaPhieuDatBan(string mapdb, string mab, string makh, string sdt, string ngaydat, string giodat, string tinhtrang)
        {
            string query = "UPDATE PHIEUDATBAN SET ";
            query += "MaB=" + int.Parse(mab) + ", ";
            query += "MaKH='" + makh + "', ";
            query += "NgayDat='" + ngaydat + "', ";
            query += "GioDat='" + giodat + "', ";
            query += "TinhTrang='" + tinhtrang + "' ";
            query += "WHERE MaPDB='" + mapdb + "'";
            int result = provider.ExecuteNonQuery(query);
            if (result == 1)
            {
                query = "UPDATE KHACHHANG SET ";
                query += "SDT_KH='" + sdt + "' WHERE MaKH='" + makh + "'";
                result = provider.ExecuteNonQuery(query);
            }
            return result;
        }
        public int XoaPhieuDatBan(string mapdb)
        {
            string query = "DELETE PHIEUDATBAN WHERE MaPDB='" + mapdb + "'";
            int result = provider.ExecuteNonQuery(query);
            return result;
        }
        public List<PHIEUDATBAN> TimPhieuDatBan(string noidung)
        {
            List<PHIEUDATBAN> orderList = new List<PHIEUDATBAN>();
            string query = "SELECT DISTINCT MaPDB, MaB, PDB.MaKH, SDT_KH, NgayDat, GioDat FROM PHIEUDATBAN AS PDB, KHACHHANG AS KH" +
                " WHERE TinhTrang = 'false' AND MaPDB LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH OR MaB LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH  OR PDB.MaKH LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH" +
                " OR TinhTrang = 'false' AND NgayDat LIKE '%" + noidung.Replace('/', '-') + "%' AND PDB.MaKH = KH.MaKH OR TinhTrang = 'false' AND GioDat LIKE '%" + noidung + "%'" +
                " AND PDB.MaKH = KH.MaKH OR TinhTrang = 'false' AND SDT_KH LIKE '%" + noidung + "%' AND PDB.MaKH = KH.MaKH";
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

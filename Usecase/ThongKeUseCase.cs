using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;

namespace Usecase
{
    public class ThongKeUseCase
    {
        private DataProvider provider = new DataProvider();
        public List<THONGKE> LoadThongKeNgay(string ngay, string thang, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string query = "DECLARE @tongtien money SET @tongtien = (SELECT SUM(TongThanhToan) FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%');";
            query += " DECLARE @tenKM char(5) SET @tenKM = (SELECT KM.MaKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                " WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //khuyen mai su dung nhieu nhat
            query += " DECLARE @slKM int SET @slKM = (SELECT KM.tongKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                " WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //so lam ap dung khuyen mai ban chay nhat
            query += " DECLARE @maM char(5) SET @maM = (SELECT M.MaM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)" +
                " DECLARE @tenM nvarchar(30) SET @tenM=(SELECT TenM FROM MONAN WHERE MaM=@maM)";
            query += " DECLARE @slM int SET @slM = (SELECT M.tongM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)";
            query += " DECLARE @tongL money SET @tongL = (SELECT SUM(LuongCoBan) + SUM(HeSoLuong) AS luong FROM NHANVIEN, LUONGNV, LUONG" +
                " WHERE NHANVIEN.MaNV = LUONGNV.MaNV AND LUONGNV.MaBacLuong = LUONG.MaBacLuong)";
            query += " SELECT DISTINCT '" + ngay + "-" + thang + "-" + nam + "' AS ThoiGian, @tongtien as TongDoanhThu, @tenM AS TenMonBanChay, @slM AS TongSoOrder, @tenKM AS TenKhuyenMai, @slKM AS TongLanApDung, @tongL as TongLuongNV FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + ngay + "%';";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item[1] = item[1].ToString().Split(".")[0];
                item[6] = item[6].ToString().Split(".")[0];
                THONGKE tk = new THONGKE(item);
                dsThongke.Add(tk);
            }
            return dsThongke;
        }

        public List<THONGKE> LoadThongKeThang(string thang, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            for (int i = 1; i <= 31; i++)
            {
                string temp = "0";
                if (i < 10)
                {
                    temp = temp + i.ToString();
                }
                else
                {
                    temp = i.ToString();
                }
                string query = "DECLARE @tongtien money SET @tongtien = (SELECT SUM(TongThanhToan) FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%');";
                query += " DECLARE @tenKM char(5) SET @tenKM = (SELECT KM.MaKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                    " WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //khuyen mai su dung nhieu nhat
                query += " DECLARE @slKM int SET @slKM = (SELECT KM.tongKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                    " WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //so lam ap dung khuyen mai ban chay nhat
                query += " DECLARE @maM char(5) SET @maM = (SELECT M.MaM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                    " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)" +
                    " DECLARE @tenM nvarchar(30) SET @tenM=(SELECT TenM FROM MONAN WHERE MaM=@maM)";
                query += " DECLARE @slM int SET @slM = (SELECT M.tongM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                    " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)";
                query += " DECLARE @tongL money SET @tongL = (SELECT SUM(LuongCoBan) + SUM(HeSoLuong) AS luong FROM NHANVIEN, LUONGNV, LUONG" +
                    " WHERE NHANVIEN.MaNV = LUONGNV.MaNV AND LUONGNV.MaBacLuong = LUONG.MaBacLuong)";
                query += " SELECT DISTINCT '" + temp + "-" + thang + "-" + nam + "' AS ThoiGian, @tongtien as TongDoanhThu, @tenM AS TenMonBanChay, @slM AS TongSoOrder, @tenKM AS TenKhuyenMai, @slKM AS TongLanApDung, @tongL as TongLuongNV FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + thang + "-" + temp + "%';";
                DataTable data = provider.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    item[1] = item[1].ToString().Split(".")[0];
                    item[6] = item[6].ToString().Split(".")[0];
                    THONGKE tk = new THONGKE(item);
                    dsThongke.Add(tk);
                }
            }

            return dsThongke;
        }

        public List<THONGKE> LoadThongKeNam(string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            for (int i = 1; i <= 12; i++)
            {
                string temp = "0";
                if (i < 10)
                {
                    temp = temp + i.ToString();
                }
                else
                {
                    temp = i.ToString();
                }
                string query = "DECLARE @tongtien money SET @tongtien = (SELECT SUM(TongThanhToan) FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + temp + "%');";
                query += " DECLARE @tenKM char(5) SET @tenKM = (SELECT KM.MaKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                    " WHERE NgayLap LIKE '%" + nam + "-" + temp + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //khuyen mai su dung nhieu nhat
                query += " DECLARE @slKM int SET @slKM = (SELECT KM.tongKM FROM(SELECT TOP 1 COUNT(MaKM)AS tongKM, MaKM FROM HOADON" +
                    " WHERE NgayLap LIKE '%" + nam + "-" + temp + "%' GROUP BY MaKM ORDER BY COUNT(MaKM) DESC) AS KM)"; //so lam ap dung khuyen mai ban chay nhat
                query += " DECLARE @maM char(5) SET @maM = (SELECT M.MaM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                    " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + temp + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)" +
                    " DECLARE @tenM nvarchar(30) SET @tenM=(SELECT TenM FROM MONAN WHERE MaM=@maM)";
                query += " DECLARE @slM int SET @slM = (SELECT M.tongM FROM(SELECT DISTINCT TOP 1 MaM, SUM(SL_Mon) AS tongM FROM CTHD, HOADON" +
                    " WHERE CTHD.MaHD = HOADON.MaHD AND NgayLap LIKE '%" + nam + "-" + temp + "%' GROUP BY MaM ORDER BY SUM(SL_Mon) DESC) AS M)";
                query += " DECLARE @tongL money SET @tongL = (SELECT SUM(LuongCoBan) + SUM(HeSoLuong) AS luong FROM NHANVIEN, LUONGNV, LUONG" +
                    " WHERE NHANVIEN.MaNV = LUONGNV.MaNV AND LUONGNV.MaBacLuong = LUONG.MaBacLuong)";
                query += " SELECT DISTINCT '" + temp + "-" + nam + "' AS ThoiGian, @tongtien as TongDoanhThu, @tenM AS TenMonBanChay, @slM AS TongSoOrder, @tenKM AS TenKhuyenMai, @slKM AS TongLanApDung, @tongL as TongLuongNV FROM HOADON WHERE NgayLap LIKE '%" + nam + "-" + temp + "%';";
                DataTable data = provider.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    item[1] = item[1].ToString().Split(".")[0];
                    item[6] = item[6].ToString().Split(".")[0];
                    THONGKE tk = new THONGKE(item);
                    dsThongke.Add(tk);
                }
            }

            return dsThongke;
        }
    }
}
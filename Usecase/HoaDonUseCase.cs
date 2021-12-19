using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Domain.Entities;

namespace Usecase
{
    public class HoaDonUseCase
    {
        private DataProvider provider = new DataProvider();

        public string GetUncheckBillIdByTableId(int id)
        {
            string query = "Select MaHD, MaNV, MaB, MaKM,NgayLap,GioVao, GioRa,SL_Khach,TongThanhToan,TienKhachDua,TienThua from dbo.HOADON";
            query = query + " where MaB = '"+id+"' And TinhTrang = 'false'";
            DataTable data = provider.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                HOADON hd = new HOADON(data.Rows[0]);
                return hd.MaHD;
            }
            return "-1";
        }

        public int InsertHoaDon(string manv, int mab, string makm, int slkhach,DateTime ngaylap)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.HOADON");
            stt = data.Rows.Count + 1;
            string temp = "";
            temp = stt.ToString().PadLeft(8, '0');

            string query = "Insert into dbo.HOADON values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12);";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, "HD"+temp));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, manv));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, makm));
            list.Add(new DataTypeSql("@5", SqlDbType.Date, ngaylap));
            list.Add(new DataTypeSql("@6", SqlDbType.VarChar, DateTime.Now.ToString("yyyy/MM/dd HH:mm")));
            list.Add(new DataTypeSql("@7", SqlDbType.VarChar, ""));
            list.Add(new DataTypeSql("@8", SqlDbType.Int, slkhach));
            list.Add(new DataTypeSql("@9", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@10", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@11", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@12", SqlDbType.Bit, 0));
            int result = provider.ExecuteNonQuery(query,list);
            return result;
        }
        public int InsertHoaDonGop(string mahd,string manv, int mab, string makm, int slkhach)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.HOADON");
            stt = data.Rows.Count + 1;
            string temp = "";
            temp = stt.ToString().PadLeft(8, '0');

            string query = "Insert into dbo.HOADON values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12);";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, manv));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, makm));
            list.Add(new DataTypeSql("@5", SqlDbType.Date, DateTime.Now.ToString("yyyy/MM/dd HH:mm")));
            list.Add(new DataTypeSql("@6", SqlDbType.VarChar, DateTime.Now.ToString("yyyy/MM/dd HH:mm")));
            list.Add(new DataTypeSql("@7", SqlDbType.VarChar, ""));
            list.Add(new DataTypeSql("@8", SqlDbType.Int, slkhach));
            list.Add(new DataTypeSql("@9", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@10", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@11", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@12", SqlDbType.Bit, 0));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public string getMaxIdHD()
        {
            try
            {
                return (string)provider.ExecuteScalar("Select MAX(MaHD) from dbo.HOADON");
            }
            catch
            {
                return "1";
            }
        }

        public int SuaSLKhachHoaDon(string mahd,int mab, int slkhach)
        {
            string query = "UPDATE hoadon SET SL_Khach = @1 where MaHD = @2 and mab=@3 ;";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, slkhach));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }
        public int XoaHoaDon(string mahd, int mab)
        {
            string query = "delete hoadon where MaHD = @1 and mab=@2 ;";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mahd));
            list.Add(new DataTypeSql("@2", SqlDbType.Int, mab));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }
        public int SuaTienThanhToanHoaDon(string mahd,decimal tienmat,decimal tienthua)
        {
            List<int> dsBanAn = new List<int>();
            dsBanAn = LayDSBanAnMaHD(mahd);
            int result = 0;
            foreach (int maban in dsBanAn)
            {
                string query = "UPDATE hoadon SET TienKhachDua = @1,TienThua=@3 where MaHD = @2 and mab = @4 ;";
                List<DataTypeSql> list = new List<DataTypeSql>();
                list.Add(new DataTypeSql("@1", SqlDbType.Money, tienmat/dsBanAn.Count));
                list.Add(new DataTypeSql("@2", SqlDbType.Char, mahd));
                list.Add(new DataTypeSql("@3", SqlDbType.Money, tienthua / dsBanAn.Count));
                list.Add(new DataTypeSql("@4", SqlDbType.Int, maban));
                result = provider.ExecuteNonQuery(query, list);
            }
            
            return result;
        }
        public int SwitchTable(string mahd,string manv, int mab,int banmoi,int slkhach,string makm)
        {
            InsertHoaDonGop(mahd,manv,banmoi,makm,slkhach);
            string query = "select * from cthd where mahd='" + mahd + "' and mab = '"+mab+"';";
            DataTable data = provider.ExecuteQuery(query);
            CTHDUseCase cthd = new CTHDUseCase();
            foreach (DataRow row in data.Rows)
            {
                cthd.DeleteCTHD(mahd, (string)row[2],mab);
                cthd.InsertCTHD((string)row[0], banmoi, (string)row[2],(int)row[3],(decimal)row[4]);
            }
            int result = XoaHoaDon(mahd, mab);
            //int result = XoaHoaDon(mahd, mab);
            return result;
        }

        public int LaySoKhachHD(int id)
        {
            string query = "Select MaHD, MaNV, MaB, MaKM,NgayLap,GioVao, GioRa,SL_Khach,TongThanhToan,TienKhachDua,TienThua from dbo.HOADON";
            query = query + " where MaB = " + id + " And TinhTrang = 'false'";
            DataTable data = provider.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                HOADON hd = new HOADON(data.Rows[0]);
                return hd.SLKhach;
            }
            return -1;
        }

        public void CheckOut(string id, decimal tongthanhtoan,string makm)
        {
            List<int> dsBanAn = new List<int>();
            dsBanAn = LayDSBanAnMaHD(id);
            foreach(int mab in dsBanAn)
            {
                string query = "update dbo.hoadon set tinhtrang ='true', TongThanhToan = @1, GioRa=@3,MaKM=@4 where mahd= @2 and mab=@5;";
                //provider.ExecuteNonQuery(query);
                List<DataTypeSql> list = new List<DataTypeSql>();
                list.Add(new DataTypeSql("@1", SqlDbType.Money, tongthanhtoan/dsBanAn.Count));
                list.Add(new DataTypeSql("@2", SqlDbType.Char, id));
                list.Add(new DataTypeSql("@3", SqlDbType.VarChar, DateTime.Now.ToString("yyyy/MM/dd HH:mm")));
                list.Add(new DataTypeSql("@4", SqlDbType.Char, makm));
                list.Add(new DataTypeSql("@5", SqlDbType.Int, mab));
                int result = provider.ExecuteNonQuery(query, list);
                BanAnUseCase banAnUseCase = new BanAnUseCase();
                banAnUseCase.SuaBanAn(mab, banAnUseCase.LaySoKhachToiDa(mab), 1);
            } 
        }
        public XUATHD LayThongTinHoaDon(string mahd)
        {
            string query = "select hoadon.manv,mahd,NHANVIEN.HoTenNV,KHUYENMAI.PhanTramKM,tongthanhtoan,TienKhachDua,tienthua from hoadon,nhanvien,KHUYENMAI where hoadon.MaKM=KHUYENMAI.MaKM and hoadon.MaNV=NHANVIEN.MaNV and hoadon.mahd='"+mahd+"';";
            DataTable data = provider.ExecuteQuery(query);
            XUATHD xUATHOADON = new XUATHD(data.Rows[0]);
            return xUATHOADON;
        }
        public List<int> LayDSBanAnMaHD(string mahd)
        {
            List<int> list = new List<int>();
            string query = "select mab from hoadon where mahd='" + mahd + "';";
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                list.Add((int)row["mab"]);
            }
            return list;
        }
    }
}

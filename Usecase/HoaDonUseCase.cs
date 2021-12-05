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

        public int InsertHoaDon(string manv, int mab, string makm, int slkhach)
        {
            int stt = 0;
            DataTable data = provider.ExecuteQuery("Select * from dbo.HOADON");
            stt = data.Rows.Count + 1;
            string temp = "";
            if(stt < 10)
            {
                temp = "0" + stt.ToString();
            }
            else
            {
                temp = stt.ToString();
            }

            string query = "Insert into dbo.HOADON values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12);";
            //query = query + "'HD" + temp + "'";
            //query = query + "," + "'" + manv + "'";
            //query = query + "," + " " + mab ;
            //query = query + "," + "'" + makm + "'";
            //query = query + "," + " GETDATE()";
            //query = query + "," + "'"  + "'";
            //query = query + "," + "'"  + "'";
            //query = query + "," + " " + slkhach;
            //query = query + "," + " " + 0;
            //query = query + "," + " " + 0;
            //query = query + "," + " " + 0;
            //query = query + "," + "'false'";
            //query = query + ")";
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, "HD"+temp));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, manv));
            list.Add(new DataTypeSql("@3", SqlDbType.Int, mab));
            list.Add(new DataTypeSql("@4", SqlDbType.Char, makm));
            list.Add(new DataTypeSql("@5", SqlDbType.Date, DateTime.Today));
            list.Add(new DataTypeSql("@6", SqlDbType.Char, ""));
            list.Add(new DataTypeSql("@7", SqlDbType.Char, ""));
            list.Add(new DataTypeSql("@8", SqlDbType.Int, slkhach));
            list.Add(new DataTypeSql("@9", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@10", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@11", SqlDbType.Money, 0));
            list.Add(new DataTypeSql("@12", SqlDbType.Bit, 0));
            int result = provider.ExecuteNonQuery(query,list);
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

        public int SuaSLKhachHoaDon(string mahd, int slkhach)
        {
            string query = "UPDATE hoadon SET SL_Khach = @1 where MaHD = @2 ;";
            //query += "SL_Khach =" + slkhach;
            //query += "WHERE MaHD = '" + mahd + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Int, slkhach));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mahd));
            int result = provider.ExecuteNonQuery(query, list);
            return result;
        }

        public int SwitchTable(string mahd, int mab)
        {
            string query = "UPDATE hoadon SET MaB = @1 where MaHD = @2 ;";
            //query += "MaB =" + mab;
            //query += "WHERE MaHD = '" + mahd + "'";
            //int result = provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Char, mab));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, mahd));
            int result = provider.ExecuteNonQuery(query, list);
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

        public void CheckOut(string id, decimal tongthanhtoan)
        {
            string query = "update dbo.hoadon set tinhtrang ='true', TongThanhToan = @1 where mahd= @2 ;";
            //provider.ExecuteNonQuery(query);
            List<DataTypeSql> list = new List<DataTypeSql>();
            list.Add(new DataTypeSql("@1", SqlDbType.Money, tongthanhtoan));
            list.Add(new DataTypeSql("@2", SqlDbType.Char, id));
            int result = provider.ExecuteNonQuery(query, list);
        }
    }
}

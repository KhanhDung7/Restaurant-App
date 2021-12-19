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
        public List<THONGKE> LoadThongKeQuy(int quy, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string timeStart = "";
            string timeEnd = "";
            switch (quy)
            {
                case 1:
                    timeStart = nam + "/1/1";
                    timeEnd = nam + "/3/31";
                    break;
                case 2:
                    timeStart = nam + "/4/1";
                    timeEnd = nam + "/6/30";
                    break;
                case 3:
                    timeStart = nam + "/7/1";
                    timeEnd = nam + "/9/30";
                    break;
                case 4:
                    timeStart = nam + "/10/1";
                    timeEnd = nam + "/12/31";
                    break;
                default:break;
            }
            string query = "select Month(ngaylap) as ngaylap,sum(tongthanhtoan) as tongdoanhthu from hoadon where NgayLap between '" + timeStart + "' and '" + timeEnd + "' group by Month(ngaylap) order by MONTH(ngaylap) asc;";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item[1] = item[1].ToString().Split(".")[0];
                THONGKE tk = new THONGKE(item);
                dsThongke.Add(tk);
            }
            return dsThongke;
        }
        public List<THONGKE> LoadThongKeMonAnQuy(int quy, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string timeStart = "";
            string timeEnd = "";
            switch (quy)
            {
                case 1:
                    timeStart = nam + "/1/1";
                    timeEnd = nam + "/3/31";
                    break;
                case 2:
                    timeStart = nam + "/4/1";
                    timeEnd = nam + "/6/30";
                    break;
                case 3:
                    timeStart = nam + "/7/1";
                    timeEnd = nam + "/9/30";
                    break;
                case 4:
                    timeStart = nam + "/10/1";
                    timeEnd = nam + "/12/31";
                    break;
                default: break;
            }
            string query = "select tenm as ngaylap,sum(sl_mon) as tongdoanhthu from hoadon,cthd,MONAN where  hoadon.mahd=cthd.mahd and cthd.mam=monan.mam and NgayLap between '" + timeStart + "' and '" + timeEnd + "' group by tenm;";

            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item[1] = item[1].ToString().Split(".")[0];
                THONGKE tk = new THONGKE(item);
                dsThongke.Add(tk);
            }
            return dsThongke;
        }
        public List<THONGKE> LoadThongKeThang(string thang, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string query = "select DAY(ngaylap) as ngaylap,sum(tongthanhtoan) as tongdoanhthu from hoadon where MONTH(ngaylap)='" + thang + "' and YEAR(ngaylap)='" + nam + "' group by DAY(ngaylap)  order by DAY(ngaylap) asc ;";
                DataTable data = provider.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    item[1] = item[1].ToString().Split(".")[0];
                    THONGKE tk = new THONGKE(item);
                    dsThongke.Add(tk);
                }
            return dsThongke;
        }

        public List<THONGKE> LoadThongKeNam(string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
                string query = "select MONTH(ngaylap) as ngaylap,sum(tongthanhtoan) as tongdoanhthu from hoadon where YEAR(ngaylap)='" + nam+ "' group by MONTH(ngaylap) order by MONTH(ngaylap) asc;";
                DataTable data = provider.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    item[1] = item[1].ToString().Split(".")[0];
                    THONGKE tk = new THONGKE(item);
                    dsThongke.Add(tk);
                }
            return dsThongke;
        }
        public List<THONGKE> LoadThongKeMonAnNam(string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string query = "select tenm as ngaylap,sum(sl_mon) as tongdoanhthu from hoadon,cthd,MONAN where hoadon.mahd=cthd.mahd and cthd.mam=monan.mam and year(ngaylap)='"+nam+"' group by tenm ;";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                THONGKE tk = new THONGKE(item);
                dsThongke.Add(tk);
            }
            return dsThongke;
        }
        public List<THONGKE> LoadThongKeMonAnThang(string thang, string nam)
        {
            List<THONGKE> dsThongke = new List<THONGKE>();
            string query = "select tenm as ngaylap,sum(sl_mon) as tongdoanhthu from hoadon,cthd,MONAN where hoadon.mahd=cthd.mahd and cthd.mam=monan.mam and year(ngaylap)='" + nam + "' and  MONTH(ngaylap)='"+thang+"' group by tenm ;";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                item[1] = item[1].ToString().Split(".")[0];
                THONGKE tk = new THONGKE(item);
                dsThongke.Add(tk);
            }
            return dsThongke;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HOADON
    {
        private string maHD;
        private string maNV, maKM, gioVao, gioRa;
        private int maB, sLKhach;
        private DateTime ngayLap;
        private decimal tongThanhToan, tienKhachDua, tienThua;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKM { get => maKM; set => maKM = value; }
        public string GioVao { get => gioVao; set => gioVao = value; }
        public string GioRa { get => gioRa; set => gioRa = value; }
        public int MaB { get => maB; set => maB = value; }
        public int SLKhach { get => sLKhach; set => sLKhach = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public decimal TongThanhToan { get => tongThanhToan; set => tongThanhToan = value; }
        public decimal TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public decimal TienThua { get => tienThua; set => tienThua = value; }

        public HOADON(string mahd, string manv, int mab, string makm, DateTime ngaylap, string giovao, string giora, int slkhach, decimal tongthanhtoan, decimal tienkhachdua, decimal tienthua)
        {
            this.MaHD = mahd;
            this.MaNV = manv;
            this.MaB = mab;
            this.MaKM = makm;
            this.NgayLap = ngaylap;
            this.GioVao = giovao;
            this.GioRa = giora;
            this.SLKhach = slkhach;
            this.TongThanhToan = tongthanhtoan;
            this.TienKhachDua = tienkhachdua;
            this.TienThua = tienthua;
        }

        public HOADON(DataRow row)
        {
            this.MaHD = (string)row["MaHD"];
            this.MaNV = (string)row["MaNV"];
            this.MaB = (int)row["MaB"];
            this.MaKM = (string)row["MaKM"];

            var ngayLapTemp = row["NgayLap"];
            if (ngayLapTemp.ToString() != "")
                this.NgayLap = (DateTime)ngayLapTemp;

            this.GioVao = (string)row["GioVao"];
            this.GioRa = (string)row["GioRa"];
            this.SLKhach = (int)row["SL_Khach"];
            this.TongThanhToan = (decimal)row["TongThanhToan"];
            this.TienKhachDua = (decimal)row["TienKhachDua"];
            this.TienThua = (decimal)row["TienThua"];
        }
    }
}

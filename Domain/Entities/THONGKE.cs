using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class THONGKE
    {
        private string thoiGian;
        private decimal tongDoanhThu;
        private string tenMonBanChay;
        private int tongSoOrder;
        private string tenKhuyenMai;
        private int tongLanApDung;
        private decimal tongLuongNV;

        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public decimal TongDoanhThu { get => tongDoanhThu; set => tongDoanhThu = value; }
        public string TenMonBanChay { get => tenMonBanChay; set => tenMonBanChay = value; }
        public int TongSoOrder { get => tongSoOrder; set => tongSoOrder = value; }
        public string TenKhuyenMai { get => tenKhuyenMai; set => tenKhuyenMai = value; }
        public int TongLanApDung { get => tongLanApDung; set => tongLanApDung = value; }
        public decimal TongLuongNV { get => tongLuongNV; set => tongLuongNV = value; }


        public THONGKE() { }

        public THONGKE(string thoigian, decimal tongdoanhthu, string tenmonbanchay, int tongsoorder, string tenkhuyenmai, int tonglanapdung, decimal tongluongnv)
        {
            this.ThoiGian = thoigian;
            this.TongDoanhThu = tongdoanhthu;
            this.TenMonBanChay = tenmonbanchay;
            this.TongSoOrder = tongsoorder;
            this.TenKhuyenMai = tenkhuyenmai;
            this.TongLanApDung = tonglanapdung;
            this.TongLuongNV = tongluongnv;
        }

        public THONGKE(DataRow row)
        {
            this.ThoiGian = (string)row["ThoiGian"];
            this.TongDoanhThu = (decimal)row["TongDoanhThu"];
            this.TenMonBanChay = (string)row["TenMonBanChay"];
            this.TongSoOrder = (int)row["TongSoOrder"];
            this.TenKhuyenMai = (string)row["TenKhuyenMai"];
            this.TongLanApDung = (int)row["TongLanApDung"];
            this.TongLuongNV = (decimal)row["TongLuongNV"];
        }

    }
}
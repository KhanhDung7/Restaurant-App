using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Domain.Entities;

namespace Domain.Entities
{
    public class NHANVIEN
    {
        public NHANVIEN(string manv, string hotennv, string cmnd, string sdtnv, string mail, DateTime ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau, Boolean tinhtrang)
        {
            this.MaNV = manv;
            this.HoTenNV = hotennv;
            this.CMND_NV = cmnd;
            this.SDT_NV = sdtnv;
            this.Mail_NV = mail;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.HoTen_NguoiLH = hoten_nguoilienhe;
            this.SDT_NguoiLH = sdt_nguoilienhe;
            this.MaChucVu = machucvu;
            this.MatKhau = matkhau;
            //this.TinhTrang = true;
        }
        public NHANVIEN()
        {
            this.MaNV = "";
            this.HoTenNV = "";
            this.CMND_NV = "";
            this.SDT_NV = "";
            this.Mail_NV = "";
            this.NgaySinh = DateTime.Now;
            this.DiaChi = "";
            this.HoTen_NguoiLH = "";
            this.SDT_NguoiLH = "";
            this.MaChucVu = 0;
            this.MatKhau = "";
            this.tenChucVu = "";
        }
        public NHANVIEN(DataRow row)
        {
            this.MaNV = (string)row["MANV"];
            this.hoTenNV = (string)row["HOTENNV"];
            this.CMND_NV = (string)row["CMND_NV"];
            this.SDT_NV = (string)row["SDT_NV"];
            this.Mail_NV = (string)row["Mail_NV"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.DiaChi = (string)row["DiaChi"];
            this.HoTen_NguoiLH = (string)row["HoTen_NguoiLH"];
            this.SDT_NguoiLH = (string)row["SDT_NguoiLH"];
            this.MaChucVu = (int)row["MaCV"];
            this.MatKhau = (string)row["MatKhau"];
            this.tenChucVu = (string)row["tencv"];
        }
        private string maNV;
        private string hoTenNV;

        private string cMND_NV;
        private string sDT_NV;
        private string mail_NV;
        private DateTime ngaySinh;
        private string diaChi;
        private string hoTen_NguoiLH;
        private string sDT_NguoiLH;
        private int maChucVu;
        private string tenChucVu;
        private string matKhau;
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string CMND_NV { get => cMND_NV; set => cMND_NV = value; }
        public string SDT_NV { get => sDT_NV; set => sDT_NV = value; }
        public string Mail_NV { get => mail_NV; set => mail_NV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string HoTen_NguoiLH { get => hoTen_NguoiLH; set => hoTen_NguoiLH = value; }
        public string SDT_NguoiLH { get => sDT_NguoiLH; set => sDT_NguoiLH = value; }
        public int MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
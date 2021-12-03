using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class staffTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("nv01")]      
        [TestCase("nv2")]       
        [TestCase(" ")]         
        [TestCase("dung' or '1'='1")]     
        [TestCase("dung';DELETE NHANVIEN WHERE MaNV='dung' OR '1'='1")]    
        public void TimNhanVien(string noidung)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            List<NHANVIEN> timNhanVien = NhanVienUseCase.TimNhanVien(noidung);
            var actualCount = timNhanVien.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay nhan vien");

        }

        [TestCase("nv7", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh'--", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788'--", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321'--", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123'--", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000'--", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM'--", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung'--", "0123456798", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798'--", "1", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1'--", "123456")]
        [TestCase("dung", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456'--")]

        public void SuaNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            int suaNhanVien = NhanVienUseCase.SuaNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi, hoten_nguoilienhe, sdt_nguoilienhe, machucvu, matkhau);
            var actualCount = suaNhanVien;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }
    }
}
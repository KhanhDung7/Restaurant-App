using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class orderTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }
        [TestCase("pdb01")]         //passed
        [TestCase("pdb02")]         //failed
        [TestCase(" ")]            //failed
        [TestCase("dung' or '1'='1' --")]
        [TestCase("dung';DELETE PHIEUDATBAN WHERE MaPDB='dung' OR '1'='1'")]
  
        public void TimPhieuDatBan(string noidung)
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();
            var expectedCount = 1;

            //Act
            List<PHIEUDATBAN> orderlist = PhieuDatBanUseCase.TimPhieuDatBan(noidung);
            var actualCount = orderlist.Count;


            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay phieu dat ban");

        }

        [TestCase("pdb01", "10", "KH08", "0123456789", "11-05-2020", "01:00", "0")]    
        [TestCase("pdb02", "10", "KH08", "0123456789", "11-05-2020", "01:00", "0")]    
        [TestCase("dung", "10'--", "KH08", "0123456789", "11-05-2020", "01:00", "1")]    
        [TestCase("dung", "10", "KH08'--", "0123456789", "11-05-2020", "01:00", "1")]    
        [TestCase("dung", "10", "KH08", "0123456789'--", "11-05-2020", "01:00", "1")]    
        [TestCase("dung", "10", "KH08", "0123456789", "11-05-2020'--", "01:00", "1")]    
        [TestCase("dung", "10", "KH08", "0123456789", "11-05-2020", "01:00'--", "1")]    
        [TestCase("dung", "10", "KH08", "0123456789", "11-05-2020", "01:00", "1'--")]    
   
        public void SuaPhieuDatBan(string mapdb, string mab, string makh, string sdt, string ngaydat, string giodat, int tinhtrang)
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();
            var expectedCount = 1;

            //Act
            int suaPhieuDatBan = PhieuDatBanUseCase.SuaPhieuDatBan(mapdb, mab, makh, sdt, ngaydat, giodat, tinhtrang);
            var actualCount = suaPhieuDatBan;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }
    }
}
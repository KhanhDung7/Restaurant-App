using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class discountTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase("KM3")]       
        [TestCase("8/3")]       
        [TestCase("KM10")]      
        [TestCase("-1")]        
        [TestCase(" ")]         
        [TestCase("dung' or '1'='1")]
        [TestCase("dung';DELETE KHUYENMAI WHERE MaKM='dung' OR '1'='1")]       
        public void TimKhuyenMai(string noidung)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            List<KHUYENMAI> timkhuyenmai = KhuyenMaiUseCase.TimKhuyenMai(noidung);
            var actualCount = timkhuyenmai.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay khuyen mai");
        }

        [TestCase("KM7", "8/3", "08/03/2021", "09/03/2021", "20")]              
        [TestCase("KM07", "Quoc Khanh", "02/09/2021", "03/09/2021", "10")]      
        [TestCase(" ", "8/3", "08/03/2021", "09/03/2021", "15")] 
        [TestCase("dung", "8/3'--", "08/03/2021", "09/03/2021", "15")]        
        [TestCase("dung", "8/3", "08/03/2021'--", "09/03/2021", "15")]                               
        [TestCase("dung", "8/3", "08/03/2021", "09/03/2021'--", "15")]                               
        [TestCase("dung", "8/3", "08/03/2021", "09/03/2021", "15'--")]                               
                       
        public void SuaKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            int suakhuyenmai = KhuyenMaiUseCase.SuaKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm);
            var actualCount = suakhuyenmai;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }
    }
}
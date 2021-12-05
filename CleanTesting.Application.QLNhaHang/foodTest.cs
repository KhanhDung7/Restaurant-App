using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class foodTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("mon1")]
        [TestCase("1")]
        [TestCase(" ")]
        [TestCase("Mi xao hai san")]
        [TestCase("80000")]
        [TestCase("dung' or '1'='1' --")]
        [TestCase("dung';DELETE MONAN WHERE MaM='dung' OR '1'='1'")]  
        public void TimMonAn(string noidung)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();

            //Act
            List<MONAN> timMonAn = monAnUseCase.TimMonAn(noidung);
            var actualCount = timMonAn.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong tim thay mon an");
        }

        [TestCase("mon1", "Mi xao hai san", "100000")]       
        [TestCase("mon4", "Bo bit tet", "100000")]           
        [TestCase("mon7", " ", "100000")]  
        [TestCase("dung", "Mi xao hai san'--", "100000")]                        
        [TestCase("dung", "Mi xao hai san", "100000'--")]                        
        public void SuaMonAn(string mam, string tenm, decimal gia)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();
            var expectedCount = 1;

            //Act
            int themMonAn = monAnUseCase.SuaMonAn(mam, tenm, gia);
            var actualCount = themMonAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }
    }
}
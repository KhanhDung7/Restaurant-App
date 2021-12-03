using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class tableTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }
        [TestCase("1", "4", "3")]   
        [TestCase("100", "3", "1")]  
        [TestCase(" ", "3", "1")]   
        [TestCase("1", " ", "1")]   
        [TestCase("1", "2", " ")]   
        [TestCase(" ", " ", " ")]   
        [TestCase("dung", "4'--", "3")]   
        [TestCase("dung", "4", "3'--")]   
        [TestCase("dung", "4 --", "3")]   
        [TestCase("dung", "4", "3 --")]  

        public void SuaBanAn(int mab, int sokhach_toida, int tinhtrang)
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();
            var expectedCount = 1;

            //Act
            int suaBanAn = BanAnUseCase.SuaBanAn(mab, sokhach_toida, tinhtrang);
            var actualCount = suaBanAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }

        [TestCase("1")]    
        [TestCase("-1")]   
        [TestCase(" ")]    
        [TestCase("dung' or '1'='1")]
        [TestCase("dung';DELETE BANAN WHERE MaB='dung' OR '1'='1")]    
        public void TimBanAn(string noidung)
        { 
            //Arr
            var BanAnUseCase = new BanAnUseCase();
            var expectedCount = 1;

            //Act
            List<BANAN> timBanAn = BanAnUseCase.TimBanAn(noidung);
            var actualCount = timBanAn.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay ban");
        }
    }
}
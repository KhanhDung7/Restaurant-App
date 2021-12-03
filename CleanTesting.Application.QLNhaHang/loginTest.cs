using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class loginTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("nv01", "123")]       
        [TestCase("nv03", " ")]          
        [TestCase(" ", "123")]           
        [TestCase(" ", " ")]             
        [TestCase("","")]
        [TestCase("dung' or 1=1'","123")]
        [TestCase("dung'--","111")]
        public void Login(string username, string password)
        { 
            //Arr
            var CheckLoginUseCase = new CheckLoginUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = CheckLoginUseCase.Login(username, password);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sai tai khoan hoac mat khau");
        }

    }
}
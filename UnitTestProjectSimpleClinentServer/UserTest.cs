using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace UnitTestProjectSimpleClinentServer
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UsernameNullTest()
        {
            //Arrange
            string name = null;
            string goodPassword = "1";
            User user = new User(name, goodPassword);
            //Act

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UsernameWhiteSpaceTest()
        {
            //Arrange
            string name = "   ";
            string goodPassword = "1";
            User user = new User(name, goodPassword);
            //Act

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UsernameToLongTest()
        {
            //Arrange
            string name = "1234567890123456789012345678901";
            string goodPassword = "1";
            User user = new User(name, goodPassword);
            //Act

            //Assert


        }
        [TestMethod]
        
        public void UsernameCorrectTest()
        {
            //Arrange
            string name = "tim";
            string goodPassword = "1";
            User user = new User(name, goodPassword);
            //Act

            //Assert
            Assert.AreEqual(name, user.UserName);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PasswordNullTest()
        {
            //Arrange
            string goodName = "tim";
            string password = null;
            User user = new User(goodName, password);
            //Act

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PasswordWhiteSpaceTest()
        {
            //Arrange
            string goodname = "tim";
            string password = "   ";
            User user = new User(goodname, password);
            //Act

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PasswordToLongTest()
        {
            //Arrange
            string goodname = "tim";
            string password = "213123123123123123123123123123123fdff";
            User user = new User(goodname, password);
            //Act

            //Assert


        }
        [TestMethod]

        public void PasswordCorrectTest()
        {
            //Arrange
            string goodname = "tim";
            string password = "1";
            User user = new User(goodname, password);
            //Act

            //Assert
            Assert.AreEqual(password, user.Password);
        }
    }
}

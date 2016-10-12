using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace UnitTestProjectSimpleClinentServer
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MessageContentNullTest()
        {
            //Arrange
            string content = null;
            string name = "tim";
            string password = "1";
            User sender = new User(name, password);
            User receiver = new User(name,password);

            //Act
            Message message = new Message(content, sender, receiver);
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MessageSenderNullTest()
        {
            //Arrange
            string content = "hej der";
            string name = "tim";
            string password = "1";
            User sender = null;
            User receiver = new User(name, password);

            //Act
            Message message = new Message(content, sender, receiver);
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MessageReceiverNullTest()
        {
            //Arrange
            string content = "hej der";
            string name = "tim";
            string password = "1";
            User sender = new User(name, password);
            User receiver = null;

            //Act
            Message message = new Message(content, sender, receiver);
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MessageContentToLongTest()
        {
            //Arrange
            //256 long
            string content = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890555556";
            string name = "tim";
            string password = "1";
            User sender = new User(name, password);
            User receiver = new User(name, password);

            //Act
            Message message = new Message(content, sender, receiver);
            //Assert
        }
        [TestMethod]
        public void MessageCorrectTest()
        {
            //Arrange
            string content = "hej der";
            string name = "tim";
            string password = "1";
            User sender = new User(name, password);
            User receiver = new User(name, password);

            //Act
            Message message = new Message(content, sender, receiver);
            //Assert
            Assert.AreEqual(content, message.Contents);
            Assert.AreEqual(sender, message.Sender);
            Assert.AreEqual(receiver, message.Receiver);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.SMSReceiverWFA;
using System.Linq;

namespace SimCorp.IMS.TestStorage {
    [TestClass]
    public class TestNewMessageComing{
        [TestMethod]
        public void TestAdding_MessageAddedToStorage() {
            //Arrange
            MyMessage message = new MyMessage();
            EmptyMobile MyMobile = new EmptyMobile();

            //Act
            MyMobile.SMSProvider.ReceiveSMS(message);

            //Assert
            Assert.AreEqual(1, MyMobile.Storage.messageStorage.Count());
        }
    }
}

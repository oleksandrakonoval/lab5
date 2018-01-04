using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.SMSReceiverWFA;
using System.Linq;

namespace SimCorp.IMS.TestStorage {
    [TestClass]
    public class TestNewMessagesComing {
        [TestMethod]
        public void TestAdding_MessagesAddedToStorage() {
            //Arrange
            MyMessage message;
            EmptyMobile MyMobile = new EmptyMobile();

            //Act
            for (int i = 0; i < 20; i++) {
                message = new MyMessage();
                MyMobile.SMSProvider.ReceiveSMS(message);
            }

            //Assert
            Assert.AreEqual(20, MyMobile.Storage.messageStorage.Count());
        }
    }
}

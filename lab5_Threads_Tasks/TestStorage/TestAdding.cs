using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;

namespace SimCorp.IMS.TestStorage {
    [TestClass]
    public class TestAdding {
        [TestMethod]
        public void TestMessageIsAddedToStorage() {
            //Arrange
            MyMessage message = new MyMessage();
            EmptyMobile MyMobile = new EmptyMobile();

            //Act
            MyMobile.Storage.Add(message);

            //Assert
            Assert.AreEqual(1, MyMobile.Storage.messageStorage.Count);
            Assert.AreEqual(message, MyMobile.Storage.messageStorage[0]);
        }
    }
}

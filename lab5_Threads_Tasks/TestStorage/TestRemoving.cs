using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.TestStorage {
    [TestClass]
    public class TestRemoving {
        [TestMethod]
        public void TestMessageIsremovedFromStorage() {
            //Arrange
            MyMessage message;
            EmptyMobile MyMobile = new EmptyMobile();
            List<MyMessage> expectedList = new List<MyMessage>();
            //Act
            for (int i=0;i<5;i++) {
                message = new MyMessage();
                MyMobile.Storage.Add(message);
                if (i%2==0) {
                    expectedList.Add(message);
                }
            }

            MyMobile.Storage.Remove(3);
            MyMobile.Storage.Remove(1);
            

            //Assert
            Assert.AreEqual(3, MyMobile.Storage.messageStorage.Count);
            Assert.IsTrue(expectedList.SequenceEqual(MyMobile.Storage.messageStorage));
        }
    }
}

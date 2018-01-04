using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.TestFilters {
    [TestClass]
    public class TestbyUser
    {
        [TestMethod]
        public void TestFilter_ByUser_Filtered() {
            //Arrange
            MyMessage message; 
            List<MyMessage> myReceivedMessages = new List<MyMessage>();
            MyFilter filter = new MyFilter();
            for (int i = 0; i < 50; i++) {
                message= new MyMessage();
                if (message.Text != null) {
                    myReceivedMessages.Add(message);
                }
            }
            string expectedSubscriber = "+380939873546";

            //Act
            List<MyMessage> myFilteredMessages = filter.FilterbyUser(myReceivedMessages, expectedSubscriber);
            List<string> selectedUsers =
                (from m in myFilteredMessages
                 select m.User).ToList();

            //Assert
            /*   Assert.IsTrue(selectedUsers.Distinct().Count() <= 1);
               if (selectedUsers.Distinct().Count()==1) {
                   Assert.AreEqual(expectedSubscriber, selectedUsers[0]);
               }*/
            Assert.IsTrue((selectedUsers.Distinct().Count() == 0) || ((selectedUsers.Distinct().Count() == 1) && (expectedSubscriber.Equals(selectedUsers[0]))));
        }
    }
}

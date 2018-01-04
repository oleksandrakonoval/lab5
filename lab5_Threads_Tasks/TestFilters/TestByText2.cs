using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.TestFilters {
    [TestClass]
    public class TestbyText2 {
        [TestMethod]
        public void TestFilter_ByText_Filtered2() {
            //Arrange
            MyMessage message;
            List<MyMessage> myReceivedMessages = new List<MyMessage>();
            MyFilter filter = new MyFilter();
            for (int i = 0; i < 50; i++) {
                message = new MyMessage();
                if (message.Text != null) {
                    myReceivedMessages.Add(message);
                }
            }
            string expectedText = "ao";

            //Act
             List<MyMessage> myFilteredMessages = filter.FilterbyText(myReceivedMessages, expectedText);
             List<string> selectedMessages =
                 (from m in myFilteredMessages
                  select m.Text).ToList();

             //Assert
             if (selectedMessages.Count() > 0) {
                 foreach (string m in selectedMessages) {
                     Assert.IsTrue(m.Contains(expectedText));
                 }
             }
             else {
                 List<string> unselectedMessages =
                     (from m in myReceivedMessages
                      select m.Text).ToList();
                 foreach (string m in unselectedMessages) {
                     Assert.IsFalse(m.Contains(expectedText));
                 }
             }
        }
    }
}

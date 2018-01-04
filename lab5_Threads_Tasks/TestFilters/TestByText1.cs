using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.TestFilters {
    [TestClass]
    public class TestbyText {
        [TestMethod]
        public void TestFilter_ByText_Filtered1() {
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
            List<MyMessage> expectedMessages =
                (from m in myReceivedMessages
                 where m.Text.Contains(expectedText)
                 select m).ToList();

            //Assert
            Assert.IsTrue(expectedMessages.SequenceEqual(myFilteredMessages));
        }
    }
}

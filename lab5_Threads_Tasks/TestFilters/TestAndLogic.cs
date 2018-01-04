using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFilters {
    [TestClass]
    public class TestAndLogic {
        [TestMethod]
        public void TestFilter_AndLogic_Filtered() {
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
            string expectedSubscriber = "+380939873546";
            string expectedText = "ao";
            DateTime fromDate = DateTime.Now.AddDays(-1);
            DateTime toDate = DateTime.Now.AddDays(1);

            //Act
            List<MyMessage> myFilteredMessages = filter.FilterAnd(myReceivedMessages, expectedSubscriber, expectedText, fromDate, toDate);
            List<MyMessage> myExpectedMessages =
                (from m in myReceivedMessages
                 where (m.User == expectedSubscriber && m.Text.Contains(expectedText) && (fromDate<=m.ReceivingTime && toDate>m.ReceivingTime))
                 select m).ToList();

            //Assert
            Assert.IsTrue(myExpectedMessages.SequenceEqual(myFilteredMessages));
        }
    }
}

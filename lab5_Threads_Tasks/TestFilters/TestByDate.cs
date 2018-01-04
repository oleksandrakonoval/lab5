using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.TestFilters {
    [TestClass]
    public class TestbyDate {
        [TestMethod]
        public void TestFilter_Bydate_Filtered() {
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
            DateTime fromDate = DateTime.Now.AddDays(-1);
            DateTime toDate = DateTime.Now.AddDays(1);

            //Act
            List<MyMessage> myFilteredMessages = filter.FilterbyDate(myReceivedMessages, fromDate, toDate);
            List<MyMessage> expectedMessages =
                (from m in myReceivedMessages
                 where m.ReceivingTime>=fromDate && m.ReceivingTime<toDate
                 select m).ToList();

            //Assert
            Assert.IsTrue(expectedMessages.SequenceEqual(myFilteredMessages));
        }
    }
}

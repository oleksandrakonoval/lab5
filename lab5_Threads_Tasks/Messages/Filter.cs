using SimCorp.IMS.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimCorp.IMS.Messages {
    public class MyFilter {

        public List<MyMessage> FilterOr(List<MyMessage> messages, object user, string messageText, DateTime fromDate, DateTime toDate) {
            List<MyMessage> myFilteredMessages = new List<MyMessage>();
            if (user!=null) { myFilteredMessages.AddRange(FilterbyUser(messages, user.ToString())); }
            if (messageText!= "") { myFilteredMessages.AddRange(FilterbyText(messages, messageText)); }
            myFilteredMessages.AddRange(FilterbyDate(messages, fromDate, toDate));
            return myFilteredMessages.Distinct().ToList();
        }

        public List<MyMessage> FilterAnd(List<MyMessage> messages, object user, string messageText, DateTime fromDate, DateTime toDate) {
            List<MyMessage> myFilteredMessages = messages;
            if (user != null) { myFilteredMessages = FilterbyUser(myFilteredMessages, user.ToString()); }
            if (messageText != "") { myFilteredMessages = FilterbyText(myFilteredMessages, messageText); }
            myFilteredMessages = FilterbyDate(myFilteredMessages, fromDate, toDate);
            return myFilteredMessages;
        }

        public List<MyMessage> FilterbyDate(List<MyMessage> messages, DateTime fromDate, DateTime toDate) {
            List<MyMessage> myFilteredMessages;
            myFilteredMessages =
               (from m in messages
                where m.ReceivingTime >= fromDate && m.ReceivingTime < toDate
                select m).ToList();
            return myFilteredMessages;
        }

        public List<MyMessage> FilterbyUser(List<MyMessage> messages, string user) {
            List<MyMessage> myFilteredMessages;
            myFilteredMessages =
               (from m in messages
                where m.User == user
                select m).ToList();
            return myFilteredMessages;
        }

        public List<MyMessage> FilterbyText(List<MyMessage> messages, string messageText) {
            List<MyMessage> myFilteredMessages;
            myFilteredMessages =
               (from m in messages
                where m.Text.Contains(messageText)
                select m).ToList();
            return myFilteredMessages;
        }
    }
}

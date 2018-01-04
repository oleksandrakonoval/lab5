using SimCorp.IMS.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimCorp.IMS.SMSReceiverWFA {
    public class Format {

        //public delegate string FormatDelegate(string text);
        public delegate string FormatDelegate(MyMessage message);

        //public string OnSMSReceived(string message, FormatDelegate del) {
        public string OnSMSReceived(MyMessage message, FormatDelegate del) {
            return del(message);
        }

        public Dictionary<int, FormatDelegate> FormatType = new Dictionary<int, FormatDelegate>();

        public Format() {
            FormatType.Add(0, (message) => $"{message.Text}");
            FormatType.Add(1, (message) => $"[{message.ReceivingTime}] {message.Text}");
            FormatType.Add(2, (message) => $"{message.Text} [{message.ReceivingTime}]");
            FormatType.Add(3, (message) => $"{message.Text} Tin-din");
            FormatType.Add(4, (message) => $"{message.Text.ToLower()}");
            FormatType.Add(5, (message) => $"{message.Text.ToUpper()}");
        }

        public FormatDelegate GetFormatType(ComboBox combobox) {
            if (combobox.InvokeRequired) {
                return (FormatDelegate)combobox.Invoke(new Func<ComboBox, FormatDelegate>(GetFormatType), combobox);
            }
            else return FormatType[combobox.SelectedIndex];
        }

        public void ShowMessages(ListView MessageListView, List<MyMessage> myReceivedMessages, FormatDelegate currentFormat) {
            clearListView(MessageListView);
            AddMessagesToListView(MessageListView, myReceivedMessages, currentFormat);
        }

        public void clearListView(ListView MessageListView) {
            if (MessageListView.InvokeRequired) { MessageListView.Invoke(new Action<ListView> (clearListView), MessageListView); }
            else MessageListView.Items.Clear();
        }

        public void AddMessagesToListView(ListView messageListView, List<MyMessage> myReceivedMessages, FormatDelegate currentFormat) {
            if (messageListView.InvokeRequired) {
                messageListView.Invoke(new Action<ListView, List<MyMessage>, FormatDelegate>(AddMessagesToListView), messageListView, myReceivedMessages, currentFormat);
            }
            else {
                foreach (MyMessage message in myReceivedMessages) {
                    messageListView.Items.Add(new ListViewItem(new[] { message.User, OnSMSReceived(message, currentFormat) }));
                }
            }
        }
    }   
}

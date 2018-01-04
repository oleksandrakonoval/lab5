using System.Collections.Generic;
using SimCorp.IMS.Messages;
using System.Windows.Forms;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.Storage {
    public class MyStorage {
        public List<MyMessage> messageStorage = new List<MyMessage>();

        public void Add(MyMessage message) {
            messageStorage.Add(message);
            RaiseSMSAddedEvent(message);
        }

        public void Remove(MyMessage message) {
            messageStorage.Remove(message);
            RaiseSMSRemovedEvent(message);
        }

        public void Remove(int num) {
            messageStorage.RemoveAt(num);
            RaiseSMSRemovedEvent(messageStorage[num]);
        }

        public delegate void SMSAddedDelegate(MyMessage message);
        public delegate void SMSRemovedDelegate(MyMessage message);

        public event SMSAddedDelegate SMSAdded;
        public event SMSRemovedDelegate SMSRemoved;

        public void RaiseSMSAddedEvent(MyMessage message) {
            SMSAdded?.Invoke(message);
        }

        public void RaiseSMSRemovedEvent(MyMessage message) {
            SMSRemoved?.Invoke(message);
        }

        public void LogAdd(TextBox storageLogTextBox, MyMessage message) {
            if (storageLogTextBox.InvokeRequired) {
                storageLogTextBox.Invoke(new Action<TextBox, MyMessage>(LogAdd), storageLogTextBox, message);
            }
            else storageLogTextBox.Text = ($"{message.ToString()} was added to the mobile storage");
        }

        public void LogRemove(TextBox storageLogTextBox, MyMessage message) {
            if (storageLogTextBox.InvokeRequired) {
                storageLogTextBox.Invoke(new Action<TextBox, MyMessage>(LogRemove), storageLogTextBox, message);
            }
            else storageLogTextBox.Text = ($"{message.ToString()} was removed from the mobile storage");
        }

    }
}

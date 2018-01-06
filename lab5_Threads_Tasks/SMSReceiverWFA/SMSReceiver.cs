using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.SMSReceiverWFA {

    public partial class SMSReceiverForm : Form {

        IOutput output;
        SimCorpMobile MyMobile;
        Format Format = new Format();
        List<MyMessage> myReceivedMessages = new List<MyMessage>();
   

        public SMSReceiverForm() {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now.AddDays(1);

            MyMobile = new SimCorpMobile();
            output = new WFAOutputRichTextBox(richTextBox1);
            MyMobile.Storage.SMSAdded += (message) => FormatAndFilter();
            MyMobile.Storage.SMSAdded += (message) => MyMobile.Storage.LogAdd(storageLogTextBox, message);
            MyMobile.Storage.SMSAdded += (message) => myReceivedMessages.Add(message);
            MyMobile.Storage.SMSAdded += (message) => MyMobile.SMSProvider.addUserToComboBox(comboBox2, message);
            MyMobile.Storage.SMSRemoved += (message) => MyMobile.Storage.LogRemove(storageLogTextBox, message);

           // MyMobile.Battery.BatteryCharger = BatteryChargerFactoty.GetBatteryType("BatteryChargerWithTreads");
            MyMobile.Battery.BatteryCharger = BatteryChargerFactoty.GetBatteryType("BatteryChargerWithTask");
            MyMobile.Battery.BatteryCharger.Charger = 100;
            MyMobile.Battery.BatteryCharger.executeCharge(checkBoxCharge, progressBarCharge);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxOrLogic.Checked == true) { checkBoxAndLogic.Checked = false; }
            FormatAndFilter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAndLogic.Checked == true) { checkBoxOrLogic.Checked = false; }
            FormatAndFilter();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
            MyMobile.SMSProvider.generateMessages(checkBoxMessages);                 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        public void FormatAndFilter() {
            FormatDelegate currentFormat;
            currentFormat = Format.GetFormatType(comboBox1);
            List<MyMessage> listToDisplay = new List<MyMessage>();
            listToDisplay = myReceivedMessages;
            MyFilter filter = new MyFilter();           
            object selectedUser = new object(); 
            if (comboBox2.Created) { selectedUser = MyMobile.SMSProvider.selectUser(comboBox2); }
            
            listToDisplay = filter.ApplyFilter(filter, myReceivedMessages, selectedUser, textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, checkBoxAndLogic, checkBoxOrLogic);
            Format.ShowMessages(MessageListView, listToDisplay, currentFormat);
        }

    }
}
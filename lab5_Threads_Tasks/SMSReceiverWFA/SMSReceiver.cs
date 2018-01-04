using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.SMSReceiverWFA {

    public partial class SMSReceiverForm : Form {

        IOutput output;
        SimCorpMobile MyMobile;
        Format Format = new Format();
        List<MyMessage> myReceivedMessages = new List<MyMessage>();
        Thread chargerDischarge;
        Thread chargerCharge;

        public SMSReceiverForm() {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now.AddDays(1);

            MyMobile = new SimCorpMobile();
            output = new WFAOutputRichTextBox(richTextBox1);
            MyMobile.Storage.SMSAdded += (message) => MyMobile.Storage.LogAdd(storageLogTextBox, message);
            MyMobile.Storage.SMSRemoved += (message) => MyMobile.Storage.LogRemove(storageLogTextBox, message);

            chargerDischarge = new Thread(Discharge);
            chargerCharge = new Thread(Charge);
            chargerDischarge.Start();
            
        }

        private void Charge() {
            while (MyMobile.Battery.Charger < 100) {
                lock (MyMobile.Battery) {                   
                    MyMobile.Battery.Charger += 1;                    
                    MyMobile.Battery.DisplayChargeChanges(progressBarCharge, MyMobile.Battery.Charger);
                    Thread.Sleep(500);
                }               
            }
        }

        private void Discharge() {
            while (MyMobile.Battery.Charger>0) {
                lock (MyMobile.Battery) {                    
                    MyMobile.Battery.Charger -= 1;
                    MyMobile.Battery.DisplayChargeChanges(progressBarCharge, MyMobile.Battery.Charger);
                    Thread.Sleep(500);
                }                                                          
            }          
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
             Thread t = new Thread(new ThreadStart(createMessage));
               if (checkBoxMessages.Checked==true) {
                  t.Start();
             }
              else 
              { t.Abort(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

        private void createMessage() {
            while (checkBoxMessages.Checked == true) {
                MyMessage message = new MyMessage();
                FormatAndFilter();
                if (message.Text != null) {
                    myReceivedMessages.Add(message);
                    MyMobile.SMSProvider.addUserToComboBox(comboBox2, message);
                }
                Thread.Sleep(1500);
                MyMobile.SMSProvider.ReceiveSMS(message);
            }
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

        private void checkBoxCharge_CheckedChanged(object sender, EventArgs e) {
            
            if (checkBoxCharge.Checked == false) {               
                //chargerCharge.Abort();
                //chargerDischarge.Suspend();
                //chargerDischarge.Start();
            }
            if (checkBoxCharge.Checked == true) {
                chargerCharge.Start();
                // chargerDischarge.Abort();
                //chargerCharge.Start();
            }
        }
    }
}
using SimCorp.IMS.Messages;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;
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
      //  BattaryCharger MyCharger;

        //Thread chargerDischarge;
        //Thread chargerCharge;

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
            MyMobile.Battery.BatteryCharger = new BatteryChargerWithTreads();
            MyMobile.Battery.BatteryCharger.Charger = 100;
            MyMobile.Battery.BatteryCharger.executeCharge(checkBoxCharge, progressBarCharge);



            /* chargerDischarge = new Thread(Discharge) { IsBackground = true };
             chargerCharge = new Thread(Charge) { IsBackground = true };
             chargerDischarge.Start();
             chargerCharge.Start();*/

        }

     /*   public void Charge() {
            while (true) {
                if (MyMobile.Battery.Charger < 100 && checkBoxCharge.Checked == true) {
                    lock (MyMobile.Battery) {
                        MyMobile.Battery.Charger += 1;
                        MyMobile.Battery.DisplayChargeChanges(progressBarCharge, MyMobile.Battery.Charger);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public void Discharge() {
            while (true) {
                if (MyMobile.Battery.Charger > 0 && checkBoxCharge.Checked == false) {
                    lock (MyMobile.Battery) {
                        MyMobile.Battery.Charger -= 1;
                        MyMobile.Battery.DisplayChargeChanges(progressBarCharge, MyMobile.Battery.Charger);
                        Thread.Sleep(1000);
                    }
                }                                                                     
            }    
        }*/

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



        /*public void generateMessages() {
            Thread t = new Thread(new ThreadStart(createMessage)) { IsBackground = true };
            if (checkBoxMessages.Checked == true) {
                t.Start();
            }
            else { t.Abort(); }
        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            FormatAndFilter();
        }

       /* private void createMessage() {
            while (checkBoxMessages.Checked == true) {
                FormatAndFilter();
                if (message.Text != null) {
                    myReceivedMessages.Add(message);
                    MyMobile.SMSProvider.addUserToComboBox(comboBox2, message);
                }
            }
        }*/

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
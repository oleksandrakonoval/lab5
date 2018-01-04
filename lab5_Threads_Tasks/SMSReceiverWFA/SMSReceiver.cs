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

        static System.Windows.Forms.Timer timer;
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
            MyMobile.Storage.SMSAdded += (message) => MyMobile.Storage.LogAdd(storageLogTextBox, message);
            MyMobile.Storage.SMSRemoved += (message) => MyMobile.Storage.LogRemove(storageLogTextBox, message);
        }

       

        private void SMSReceiverForm_Load(object sender, System.EventArgs e) {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) {
            createMessage();
        }

        private void createMessage() {
            while (checkBoxMessages.Checked == true) {
                MyMessage message = new MyMessage();
                FormatDelegate currentFormat;
                currentFormat = Format.GetFormatType(comboBox1);
                if (message.Text != null) {
                    myReceivedMessages.Add(message);
                    MyMobile.SMSProvider.addUserToComboBox(comboBox2, message);
                }
                List<MyMessage> listToDisplay = new List<MyMessage>();
                listToDisplay = myReceivedMessages;
                MyFilter filter = new MyFilter();
                object selectedUser = MyMobile.SMSProvider.selectUser(comboBox2);
                if (checkBoxAndLogic.Checked == true) {
                    listToDisplay = filter.FilterAnd(myReceivedMessages, selectedUser, textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                }
                if (checkBoxOrLogic.Checked == true) {
                    listToDisplay = filter.FilterOr(myReceivedMessages, selectedUser, textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                }

                Format.ShowMessages(MessageListView, listToDisplay, currentFormat);
                MyMobile.SMSProvider.ReceiveSMS(message);
                Thread.Sleep(2000);
            }           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxOrLogic.Checked == true) { checkBoxAndLogic.Checked = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAndLogic.Checked == true) { checkBoxOrLogic.Checked = false; }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
             Thread t = new Thread(new ThreadStart(createMessage));
               if (checkBoxMessages.Checked==true) {
                  t.Start();
             }
              else 
              { t.Abort(); }
        }
    }
}
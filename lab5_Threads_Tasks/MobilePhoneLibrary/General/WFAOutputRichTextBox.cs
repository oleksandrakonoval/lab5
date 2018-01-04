using System;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.General {
    public class WFAOutputRichTextBox : IOutput {
        private delegate void RichTextBoxUpdateEventHandler(string text);

        public static RichTextBox myRichTextBox;

        public string Output {
            get {
                throw new NotImplementedException();
            }
        }

        public void Write(string text) {
            if (myRichTextBox.InvokeRequired) {
                myRichTextBox.Invoke(new Action<string>(myWrite), text);
                return;
            }
            myRichTextBox.AppendText(text);
        }

        public void WriteLine(string text) {

            if (myRichTextBox.InvokeRequired) {
                myRichTextBox.Invoke(new RichTextBoxUpdateEventHandler(myWrite), new object[] { text+ Environment.NewLine });
            }
            else {
                myRichTextBox.AppendText(text + Environment.NewLine);
            }
        }

        public WFAOutputRichTextBox(RichTextBox richTextBox) {
            myRichTextBox = richTextBox;
        }

        public static void myWrite(string text) {
            myRichTextBox.AppendText(text);
        }

    }
}

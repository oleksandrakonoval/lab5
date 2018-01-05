using SimCorp.IMS.Messages;
using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.Provider {
    public class SMSProviderWithTread: SMSProvider {
        public override void generateMessages(CheckBox checkbox) {
            Thread t = new Thread(new ThreadStart(() => createMessage(checkbox))) { IsBackground = true };
            t.Start();
        }

        private void createMessage(CheckBox checkbox) {
            while (checkbox.Checked) {
                MyMessage message = new MyMessage();
                if (message.Text != null) {
                    ReceiveSMS(message);
                    Thread.Sleep(1500);
                }
            }
        }
    }
}

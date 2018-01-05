using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.Provider {
    public class SMSProviderWithTread: SMSProvider {
        public override void generateMessages(CheckBox checkbox) {
            Thread t = new Thread(new ThreadStart(() => createMessage(checkbox))) { IsBackground = true };
            t.Start();
        }       
    }
}

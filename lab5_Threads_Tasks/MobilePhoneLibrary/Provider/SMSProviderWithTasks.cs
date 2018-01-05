using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.Provider {
    public class SMSProviderWithTasks : SMSProvider {
        public Task generateMessagesTasks;

        public override void generateMessages(CheckBox checkbox) {
            if (generateMessagesTasks == null) {
                lock (this) {
                    if (generateMessagesTasks == null) {
                        generateMessagesTasks = new Task(() => createMessage(checkbox));
                        generateMessagesTasks.Start();
                    }
                }
            }
        }
    }
}

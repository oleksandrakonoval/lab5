using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public class BatteryChargerWithTask : BattaryCharger {

        public Task ChargeTask;
        public Task DischargeTask;        

        public override void executeCharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
            if (ChargeTask == null) {
                lock (this) {
                    if (ChargeTask == null) {                       
                        ChargeTask = new Task(()=>Charge(checkBoxCharge,progressBarCharge));
                        ChargeTask.Start();
                    }
                }
            }
            if (DischargeTask == null) {
                lock (this) {
                    if (DischargeTask == null) {
                        DischargeTask = new Task(() => Discharge(checkBoxCharge, progressBarCharge));
                        DischargeTask.Start();
                    }
                }
            }
        }
    }
}

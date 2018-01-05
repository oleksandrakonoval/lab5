using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public class BatteryChargerWithTreads : BattaryCharger {

        public override void executeCharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
            Thread chargerDischarge = new Thread(new ThreadStart(() => Discharge(checkBoxCharge, progressBarCharge))) { IsBackground = true };
            chargerDischarge.Start();
            Thread chargerCharge = new Thread(new ThreadStart(() => Charge(checkBoxCharge, progressBarCharge))) { IsBackground = true };
            chargerCharge.Start();
        }
    }
}

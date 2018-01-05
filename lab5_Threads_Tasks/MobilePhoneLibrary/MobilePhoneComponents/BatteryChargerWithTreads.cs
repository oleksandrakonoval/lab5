using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public class BatteryChargerWithTreads : BattaryCharger {

        public override void Charge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
            while (true) {
                if (Charger < 100 && checkBoxCharge.Checked == true) {
                    lock (this) {
                        Charger += 1;
                        DisplayChargeChanges(progressBarCharge, Charger);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public override void Discharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
            while (true) {
                if (Charger > 0 && checkBoxCharge.Checked == false) {
                    lock (this) {
                        Charger -= 1;
                        DisplayChargeChanges(progressBarCharge, Charger);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public override void executeCharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
            Thread chargerDischarge = new Thread(new ThreadStart(() => Discharge(checkBoxCharge, progressBarCharge))) { IsBackground = true };
            chargerDischarge.Start();
            Thread chargerCharge = new Thread(new ThreadStart(() => Charge(checkBoxCharge, progressBarCharge))) { IsBackground = true };
            chargerCharge.Start();
        }
    }
}

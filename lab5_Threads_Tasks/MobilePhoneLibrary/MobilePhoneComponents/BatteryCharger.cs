using System;
using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public abstract class BattaryCharger{

        public abstract void executeCharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge);

        private int charger;

        public int Charger {
            get { return charger; }
            set {
                if (value > 100) charger = 100;
                else if (value < 0) charger = 0;
                else charger = value;
            }
        }

        public abstract void Charge(CheckBox checkBoxCharge, ProgressBar progressBarCharge);
        public abstract void Discharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge);

        public void DisplayChargeChanges(ProgressBar progressBarCharge, int charger) {
            if (progressBarCharge.InvokeRequired) {
                progressBarCharge.Invoke(new Action<ProgressBar, int>(DisplayChargeChanges), progressBarCharge, charger);
            }
            else progressBarCharge.Value = charger;
        }
    }
}

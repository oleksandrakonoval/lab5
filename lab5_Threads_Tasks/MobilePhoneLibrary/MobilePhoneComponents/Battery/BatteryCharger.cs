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

        public void Charge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
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

        public void Discharge(CheckBox checkBoxCharge, ProgressBar progressBarCharge) {
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

        public void DisplayChargeChanges(ProgressBar progressBarCharge, int charger) {
            if (progressBarCharge.InvokeRequired) {
                progressBarCharge.Invoke(new Action<ProgressBar, int>(DisplayChargeChanges), progressBarCharge, charger);
            }
            else progressBarCharge.Value = charger;
        }
    }
}

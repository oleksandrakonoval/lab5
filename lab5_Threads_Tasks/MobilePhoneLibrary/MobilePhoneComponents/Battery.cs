using System;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public enum BatteryType {
        LiionBattery,
        NiCdBattery,
        MiMHBattery,
        SLABattery
    }

    public class Battery  {
        public BatteryType BatteryType { get; set; }

        public double Capacity { get; set; }
       
        private int charger;

        public int Charger {
            get { return charger; }
            set {
                if (value > 100) charger = 100;
                else if (value < 0) charger = 0;
                else charger = value;
            }
        }

        public Battery():this(200, (BatteryType)0) {
            this.Capacity = 200;
            this.Charger = 100;
        }

        public Battery(int capacity, BatteryType bType) {
            this.Capacity = capacity > 0 ? capacity : 200;
            this.Charger = 100;
            if (((int)bType >= 0) && ((int)bType <= 3)) {
                this.BatteryType = bType;
            }
            else { this.BatteryType = (BatteryType)0; }
        }

        public override string ToString() {
            return $"Battery capacity is {this.Capacity} mAh \r\nBattery type is {this.BatteryType}";
        }

        public void DisplayChargeChanges(ProgressBar progressBarCharge, int charger) {
            if (progressBarCharge.InvokeRequired) {
                progressBarCharge.Invoke(new Action<ProgressBar, int>(DisplayChargeChanges), progressBarCharge, charger);
            }
            else progressBarCharge.Value = charger;
        }
    }
}

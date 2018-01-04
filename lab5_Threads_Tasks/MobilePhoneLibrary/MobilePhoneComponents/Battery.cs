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

        public Battery():this(200, (BatteryType)0) {
            this.Capacity = 200;
        }

        public Battery(int capacity, BatteryType bType) {
            this.Capacity = capacity > 0 ? capacity : 200;
            if (((int)bType >= 0) && ((int)bType <= 3)) {
                this.BatteryType = bType;
            }
            else { this.BatteryType = (BatteryType)0; }
        }

        public override string ToString() {
            return $"Battery capacity is {this.Capacity} mAh \r\nBattery type is {this.BatteryType}";
        }
    }
}

using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public static class BatteryChargerFactoty {
        public static BattaryCharger GetBatteryType(string batteryType) {
            batteryType = "SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents." + batteryType;
            Type bType = Type.GetType(batteryType);
            object batteryChargerItem = Activator.CreateInstance(bType);
            BattaryCharger batteryCharger = batteryChargerItem as BattaryCharger;
            return batteryCharger;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;

namespace TestCharge {
    [TestClass]
    public class ChargeMoreThen0 {
        [TestMethod]
        public void ChargeMoreThen0Test() {
            //Arrange
            EmptyMobile MyMobile = new EmptyMobile();
            MyMobile.Battery = new Battery();
            MyMobile.Battery.BatteryCharger = BatteryChargerFactoty.GetBatteryType("BatteryChargerWithTreads");
            //Act

            MyMobile.Battery.BatteryCharger.Charger = -10;

            //Assert
            Assert.IsTrue(MyMobile.Battery.BatteryCharger.Charger >= 0);
        }

    }
}


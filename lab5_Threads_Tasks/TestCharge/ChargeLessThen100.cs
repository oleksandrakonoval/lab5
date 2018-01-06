using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;

namespace TestCharge {
    [TestClass]
    public class ChargeLessThen100
    {
        [TestMethod]
        public void ChargeLessThan100Test() {
            //Arrange
            EmptyMobile MyMobile = new EmptyMobile();
            MyMobile.Battery = new Battery();
            MyMobile.Battery.BatteryCharger = BatteryChargerFactoty.GetBatteryType("BatteryChargerWithTreads");
            //Act

            MyMobile.Battery.BatteryCharger.Charger = 105;

            //Assert
            Assert.IsTrue(MyMobile.Battery.BatteryCharger.Charger <= 100);
        }
        
    }
}

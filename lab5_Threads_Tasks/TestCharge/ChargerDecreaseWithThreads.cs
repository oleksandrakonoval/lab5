﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;
using System.Threading;
using System.Windows.Forms;

namespace TestCharge {
    [TestClass]
    public class ChargerDecreaseWithThreads {
        [TestMethod]
        public void ChargerDecreaseWithThreadsTest() {
            //Arrange           
            EmptyMobile MyMobile = new EmptyMobile();         
            MyMobile.Battery = new Battery();
            MyMobile.Battery.BatteryCharger = BatteryChargerFactoty.GetBatteryType("BatteryChargerWithTreads");
            int initialChargeValue = 100;

            CheckBox checkBoxCharge = new CheckBox();
            ProgressBar progressBarCharge = new ProgressBar();

            //Act
            checkBoxCharge.Checked = false;
            MyMobile.Battery.BatteryCharger.Charger = initialChargeValue;
            MyMobile.Battery.BatteryCharger.executeCharge(checkBoxCharge, progressBarCharge);
            //Thread.Sleep(3000);

            //Arrange
            Assert.IsTrue(initialChargeValue > MyMobile.Battery.BatteryCharger.Charger);

        }
    }
}

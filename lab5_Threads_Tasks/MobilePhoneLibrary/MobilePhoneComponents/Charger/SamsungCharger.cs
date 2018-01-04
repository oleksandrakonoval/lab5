using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{
    public class SamsungCharger : ICharger
    {
        private IOutput Output;

        public SamsungCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(SamsungCharger)} in progress");
            Output.WriteLine($"{nameof(SamsungCharger)} in progress");
        }
    }

}

using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{
    public class NokiaCharger : ICharger
    {
        private IOutput Output;

        public NokiaCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(NokiaCharger)} in progress");
            Output.WriteLine($"{nameof(NokiaCharger)} in progress");
        }
    }

}

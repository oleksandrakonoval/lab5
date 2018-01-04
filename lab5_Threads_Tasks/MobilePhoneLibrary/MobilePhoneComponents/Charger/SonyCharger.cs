using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{

    public class SonyCharger : ICharger
    {
        private IOutput Output;

        public SonyCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(SonyCharger)} in progress");
            Output.WriteLine($"{nameof(SonyCharger)} in progress");
        }
    }

}

using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{
    public class MotoCharger : ICharger
    {
        private IOutput Output;

        public MotoCharger(IOutput output)
        {
            Output = output;
        }

        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(MotoCharger)} in progress");
            Output.WriteLine($"{nameof(MotoCharger)} in progress");
        }
    }


}

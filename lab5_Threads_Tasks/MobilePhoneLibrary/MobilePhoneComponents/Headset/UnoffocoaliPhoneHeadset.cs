using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public class UnoffocoaliPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public UnoffocoaliPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(UnoffocoaliPhoneHeadset)} sound");
            Output.WriteLine($"{nameof(UnoffocoaliPhoneHeadset)} sound");
        }
    }
}
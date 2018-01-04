using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(iPhoneHeadset)} sound");
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}
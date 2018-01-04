using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;

        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(SamsungHeadset)} sound");
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }

}
using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public class PhoneSpeaker : IPlayback
    {
        private IOutput Output;

        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}

using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public class NanoSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public NanoSim(IOutput output)
        {
            Output = output;
        }

        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(NanoSim)} call");
            Output.WriteLine($"{nameof(NanoSim)} call");
        }
    }
}

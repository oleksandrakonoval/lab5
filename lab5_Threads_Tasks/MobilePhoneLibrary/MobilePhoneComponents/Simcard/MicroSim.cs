using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public class MicroSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }


        private IOutput Output;

        public MicroSim(IOutput output)
        {
            Output = output;
        }

        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(MicroSim)} call");
            Output.WriteLine($"{nameof(MicroSim)} call");
        }
    }
}
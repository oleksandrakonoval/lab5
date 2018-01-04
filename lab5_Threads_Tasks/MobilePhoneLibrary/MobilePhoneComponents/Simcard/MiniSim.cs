using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public class MiniSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public MiniSim(IOutput output)
        {
            Output = output;
        }


        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(MiniSim)} call");
            Output.WriteLine($"{nameof(MiniSim)} call");
        }
    }
}
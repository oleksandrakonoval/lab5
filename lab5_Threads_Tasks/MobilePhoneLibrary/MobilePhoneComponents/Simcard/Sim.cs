using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public class Sim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public Sim(IOutput output)
        {
            Output = output;
        }


        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(Sim)} call");
            Output.WriteLine($"{nameof(Sim)} call");
        }
    }
}
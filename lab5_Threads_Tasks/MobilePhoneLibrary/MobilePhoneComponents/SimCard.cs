namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {

    public enum SimFormat {
        nanoSim,
        microSim,
        miniSim,
        Sim
    }

    public class SimCard{

        public SimFormat Simformat { get; set; }

        public SimCard() { }

        public SimCard(int format) { this.Simformat = (SimFormat)format; }

        public override string ToString() { return $"Format: {this.Simformat}"; }
    }
}

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public class Camera {

        public double QualityMPX { get; set; }
        public bool Autofocus { get; set; }
        public bool Flash { get; set; }

        public Camera():this (1, false, false) {}

        public Camera(double quality, bool autof, bool flash) {
            this.QualityMPX = quality > 0 ? quality : 1;
            this.Autofocus = autof;
            this.Flash = flash;
        }

        public override string ToString() {
            string a = this.Flash ? "yes" : "no";
            string b= this.Autofocus? "yes" : "no";
            return $"{this.QualityMPX} MPX, flash - {a}, autofocus - {b}";
        }
    }
}

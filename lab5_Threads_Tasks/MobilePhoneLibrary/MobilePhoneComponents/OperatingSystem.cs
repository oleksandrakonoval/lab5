namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public enum OStype {
        Android,
        WindowsPhone,
        Linux,
        iOS,
        Symbian
    }

    public class OperatingSystem {

        public OStype OSType { get; set; }

        public OperatingSystem():this (2) {}

        public OperatingSystem(int OS) {
            if ((OS >= 0) && (OS <= 4)) this.OSType = (OStype)OS;
            else this.OSType = (OStype)2;
        }

        public override string ToString() {
            return $"OS Type : {this.OSType}";
        }

    }
}

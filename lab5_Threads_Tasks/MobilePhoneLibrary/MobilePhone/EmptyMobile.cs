using System;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhone {
    public class EmptyMobile : Mobile {
        public override Battery Battery {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override Camera Camera {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override Keyboard Keyboard {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override MobilePhoneComponents.OperatingSystem OperatingSystem {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override ScreenBase Screen {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override SimCard SimCard {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }
    }
}

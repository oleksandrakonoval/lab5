using SimCorp.IMS.MobilePhoneLibrary.Images;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    class RetinaScreen : ColorfulScreen {

        public RetinaScreen():base() { }

        public RetinaScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show(IScreenImage screenImage) { Console.WriteLine($"I am {nameof(RetinaScreen)}");}

        public override string ToString() { return "Retina Screen"; }
    }
}

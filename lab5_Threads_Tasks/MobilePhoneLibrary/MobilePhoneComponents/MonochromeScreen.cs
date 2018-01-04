using SimCorp.IMS.MobilePhoneLibrary.Images;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents
{

    class MonochromeScreen : ScreenBase {

        public MonochromeScreen():base() { }

        public MonochromeScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show (IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)} with brightness {brightness}");
        }

        public override string ToString() {
            return "Monochrome Screen";
        }

    }
}

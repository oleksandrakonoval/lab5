using SimCorp.IMS.MobilePhoneLibrary.Images;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents
{
    public class ColorfulScreen :ScreenBase {
        public ColorfulScreen():base() { }

        public ColorfulScreen(TouchScreenType tsType, double size, int[] pixels) : base(tsType, size, pixels) { }

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)} with brightness {brightness}");
        }

        public override string ToString() {
            return "Colorful Screen";
        }
    }
}

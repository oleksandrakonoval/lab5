using SimCorp.IMS.MobilePhoneLibrary.Images;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents{

    public enum TouchScreenType {
        SingleTouchScreen,
        MultitouchScreen,
        NoTouchScreen
    }

    public abstract class ScreenBase {

        public static int[] DefaultPixels = { 1920, 1200 };

        public TouchScreenType TouchScreenType { get; set; }
        public double Size { get; set; }
        public int[] Pixels { get; set; }

        public ScreenBase() : this((TouchScreenType)1, 4.5, DefaultPixels) { }

        public ScreenBase(TouchScreenType tsType, double size, int[] pixels)
        {
            if (((int)tsType >= 0) && ((int)tsType <= 2)) { this.TouchScreenType = tsType; }
            else this.TouchScreenType = (TouchScreenType)1;

            this.Size = size > 2 ? size : 4.5;

            if ((pixels.Length == 2) && pixels[0] > 100 && pixels[1] > 100) { this.Pixels = pixels; }
            else Pixels = DefaultPixels;
        }

        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);

        }
}

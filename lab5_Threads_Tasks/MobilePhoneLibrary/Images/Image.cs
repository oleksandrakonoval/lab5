namespace SimCorp.IMS.MobilePhoneLibrary.Images {
    public class Image : IScreenImage {
        public static int[] DefaultSize = { 720, 680 };
        public static BitDepth DefaultBitDepth = (BitDepth)3;

        public int[] ScreenSize { get; set; }
        public BitDepth BitDepth { get; set; }

        public Image() : this(DefaultSize, DefaultBitDepth) { }

        public Image(int[] size, BitDepth depth) {
            if ((size.Length == 2) && (size[0] > 0) && (size[1] > 0)) { this.ScreenSize = size; }
            else this.ScreenSize = DefaultSize;

            this.BitDepth = depth > 0 ? depth : DefaultBitDepth;
        }

        public override string ToString() {
            return $"Image with size {ScreenSize[0]}x{ScreenSize[1]} and bit depth {BitDepth.ToString()}";
        }
    }
}

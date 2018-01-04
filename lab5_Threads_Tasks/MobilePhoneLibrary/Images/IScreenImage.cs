namespace SimCorp.IMS.MobilePhoneLibrary.Images {
    public enum BitDepth {
        bit1,
        bit2,
        bit4,
        bit8,
        bit16,
        bit32
    }

    public interface IScreenImage {
        BitDepth BitDepth { get; set; }
        int[] ScreenSize { get; set; }
        string ToString();
    }
}

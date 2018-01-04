namespace SimCorp.IMS.MobilePhoneLibrary.General {
    public interface IOutput {
        void Write(string text);
        void WriteLine(string text);
        string Output { get; }
    }
}

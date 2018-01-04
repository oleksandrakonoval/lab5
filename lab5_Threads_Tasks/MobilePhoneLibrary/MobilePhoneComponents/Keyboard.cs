namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents {
    public enum Language {
        Danish,
        English,
        German,
        Russian,
        Ukraininan
    }

    public enum KeybordType {
        qwerty,
        numeric,
        other
    }

    public class Keyboard {
        
        public Language Language { get; set; }
        public KeybordType KeyboardType { get; set; }

        public Keyboard() : this(0, 1) { }
        
        public Keyboard(int ktype, int lang) {
            if ((ktype >= 0) && (ktype <= 2)) this.KeyboardType = (KeybordType)ktype;
            else this.KeyboardType = (KeybordType)0;

            if ((lang >= 0) && (lang <= 4)) this.Language = (Language)lang;
            else this.Language = (Language)1;
        }

        public override string ToString() {
            return $"Language: {(Language)}, Keyboard type: {(KeyboardType)}";
        }
    }
}

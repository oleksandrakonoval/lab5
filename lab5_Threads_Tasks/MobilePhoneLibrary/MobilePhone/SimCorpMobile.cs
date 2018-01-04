using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhone {
    public class SimCorpMobile : Mobile {

        IOutput output = new ConsoleOutput();

        public override ScreenBase Screen { get; set; }
        public override Keyboard Keyboard { get; set; }
        public override Battery Battery { get; set; }
        public override SimCard SimCard { get; set; }
        public override MobilePhoneComponents.OperatingSystem OperatingSystem { get; set; }
        public override Camera Camera { get; set; }

        public SimCorpMobile() {
            CreateSimCorpMobile();
        }

        public void CreateSimCorpMobile() {
            Screen = defineScreen();

            int ktype = defineEnumParam(typeof(KeybordType));
            int ltype = defineEnumParam(typeof(Language));
            Keyboard = new Keyboard(ktype, ltype);

            Console.WriteLine("Enter battery capacity");
            int bcapacity=Convert.ToInt32(Console.ReadLine());
            int btype = defineEnumParam(typeof(BatteryType));
            Battery = new Battery(bcapacity,(BatteryType)btype);

            int stype = defineEnumParam(typeof(SimFormat));
            SimCard = new SimCard(stype);

            int ostype = defineEnumParam(typeof(OStype));
            OperatingSystem = new MobilePhoneComponents.OperatingSystem(ostype);

            Console.WriteLine("Enter camera quality (MPx)");
            double cquality = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose autofocus (false/true)");
            bool cautofocus = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Choose flash (false/true)");
            bool cflash = Convert.ToBoolean(Console.ReadLine());
            Camera = new Camera(cquality, cautofocus, cflash);

            Console.WriteLine("_______________________");
            Console.WriteLine("Defined parameters:");
            Console.WriteLine(Screen.ToString());
            Console.WriteLine(Keyboard.ToString());
            Console.WriteLine(Battery.ToString());
            Console.WriteLine(SimCard.ToString());
            Console.WriteLine(OperatingSystem.ToString());
            Console.WriteLine(Camera.ToString());
        }

        public void ConfigureMobile() {
            int headsetType = defineEnumParam(typeof(headsetTypik));
            PlaybackComponent = HeadsetFactory.GetPlayback((headsetTypik)headsetType, output);
            PlaybackComponent.Play(new object());

            int chargerType = defineEnumParam(typeof(ChargerTypik));
            ChargerComponenet = ChargerFactory.GetCharger((ChargerTypik)chargerType, output);
            ChargerComponenet.Charge(new object());

            int simcardType = defineEnumParam(typeof(SimCardTypeik));
            SimCardItem = SimCardFactory.GetSimCard((SimCardTypeik)simcardType, output);
            SimCardItem.Call(new object());

        }
    }
}

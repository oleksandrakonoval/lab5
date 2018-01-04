using SimCorp.IMS.MobilePhoneLibrary.General;
using System;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{
    public enum ChargerTypik
    {
        SamsungCharger,
        SonyCharger,
        NokiaCharger,
        MotoCharger
    }

    public static class ChargerFactory
    {
        public static ICharger GetCharger(ChargerTypik chargerType, IOutput output)
        {
            string typeName = chargerType.ToString();
            typeName = "SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger." + typeName;
            Type hType = Type.GetType(typeName);
            object ChargerComponent = Activator.CreateInstance(hType, output);
            ICharger charger = ChargerComponent as ICharger;
            return charger;
        }
    }
}

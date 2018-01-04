using System;
using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public enum headsetTypik
    {
        iPhoneHeadset,
        SamsungHeadset,
        UnoffocoaliPhoneHeadset,
        PhoneSpeaker
    }

    public static class HeadsetFactory
    {
        public static IPlayback GetPlayback(headsetTypik headsetType,IOutput output)
        {
            string typeName = headsetType.ToString();
            typeName = "SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset." + typeName;
            Type hType = Type.GetType(typeName);
            object HeadsetComponent = Activator.CreateInstance(hType, output);
            IPlayback headset = HeadsetComponent as IPlayback;
            return headset;
        }
    }
}

using System;

namespace SimCorp.IMS.MobilePhoneLibrary.Provider {
    public static class SMSProviderFactory {
        public static SMSProvider GetSMSProvider(string providerType) {
            providerType = "SimCorp.IMS.MobilePhoneLibrary.Provider." + providerType;
            Type pType = Type.GetType(providerType);
            object providerItem = Activator.CreateInstance(pType);
            SMSProvider provider = providerItem as SMSProvider;
            return provider;
        }
    } 
}

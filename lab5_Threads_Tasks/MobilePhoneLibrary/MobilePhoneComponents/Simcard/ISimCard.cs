namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public interface ISimCard
    {
        int Number { get; set; }
        int Pin { get; set; }
        void Call(object data);
    }
}

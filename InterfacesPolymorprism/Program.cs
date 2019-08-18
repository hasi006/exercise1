namespace InterfacesPolymorprism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationchannel(new EmailNotificaton());
            encoder.RegisterNotificationchannel(new SmsNotification());

            encoder.Encode();
        }
    }
}

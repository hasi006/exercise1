using System;

namespace InterfacesPolymorprism
{
    public class SmsNotification : INotifcationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Sms is sending..");
        }
    }
}

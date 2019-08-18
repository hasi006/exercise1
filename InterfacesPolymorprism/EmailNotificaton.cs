using System;

namespace InterfacesPolymorprism
{
    public class EmailNotificaton : INotifcationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Email is sending..");
        }
    }
}

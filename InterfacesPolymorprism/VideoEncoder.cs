using System;
using System.Collections.Generic;

namespace InterfacesPolymorprism
{
    public class VideoEncoder
    {
        private readonly IList<INotifcationChannel> _notificationChannels;

        public VideoEncoder()
        {
            this._notificationChannels = new List<INotifcationChannel>();
        }

        public void Encode()
        {
            Console.WriteLine("Video is Encoding");

            foreach (var channel in _notificationChannels)
                channel.Send("xxxx");
            
        }

        public void RegisterNotificationchannel(INotifcationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}

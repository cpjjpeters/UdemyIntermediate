﻿using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Polymorphism
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
          //  _mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode( Video video)
        {

            Console.WriteLine("video being encoded");
            //_mailService.Send(new Mail());
            foreach (var channel in _notificationChannels)
                
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
    

}
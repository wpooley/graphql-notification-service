using HotChocolate.Types.Relay;
using System;

namespace Sample.Notifications.Service.Models
{
    public class Notification
    {
        [ID]
        public Guid Id { get; set;}
        public string Label { get; set; }
    }
}

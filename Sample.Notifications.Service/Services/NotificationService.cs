using Sample.Notifications.Service.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Notifications.Service.Services
{
    public class NotificationService
    {
        private List<Notification> Notifications { get; } = new List<Notification>();

        public List<Notification> GetNotifications() => Notifications;

        public Task<Notification> PushNotification(string label)
        {
            if (string.IsNullOrWhiteSpace(label))
            {
                throw new ArgumentException($"label cannot be null or whitespace");
            }

            Notification notification = new Notification { Id = Guid.NewGuid(), Label = label };
            Notifications.Add(notification);
            return Task.FromResult(notification);
        }
    }
}

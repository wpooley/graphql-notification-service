using HotChocolate;
using Sample.Notifications.Service.Services;
using System.Collections.Generic;

namespace Sample.Notifications.Service.Models
{
    public class Query
    {
        public List<Notification> GetNotifications([Service] NotificationService service)
            => service.GetNotifications();
    }
}

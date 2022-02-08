using HotChocolate;
using HotChocolate.Types;

namespace Sample.Notifications.Service.Models
{
    public class Subscription
    {
        [Subscribe]
        public Notification NewNotification([EventMessage] Notification notification) => notification;
    }
}

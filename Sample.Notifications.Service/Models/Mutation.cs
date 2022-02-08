using HotChocolate;
using HotChocolate.Subscriptions;
using Sample.Notifications.Service.Services;
using System.Threading.Tasks;

namespace Sample.Notifications.Service.Models
{
    public class Mutation
    {
        public async Task<Notification> PushNotification([GraphQLNonNullType] string label, [Service] NotificationService service, [Service] ITopicEventSender sender)
        {
            var notification = await service.PushNotification(label);
            await sender.SendAsync(nameof(Subscription.NewNotification), notification);
            return notification;
        }
    }
}

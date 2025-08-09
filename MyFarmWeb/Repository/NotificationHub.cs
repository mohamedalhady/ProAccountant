using Microsoft.AspNetCore.SignalR;

namespace MyFarmWeb.Repository
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string username, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", username, message);
        }

        public async Task SendNotificationToOneUser(string username, string message, string ToUser)
        {
            await Clients.User(ToUser).SendAsync("ReceiveMessage", username, message, Context.UserIdentifier);
        }
    }
 
}

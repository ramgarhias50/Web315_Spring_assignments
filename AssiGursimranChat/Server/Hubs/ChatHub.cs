using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AssiGursimranChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task WhileTyping(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }
        public async Task SendAnonMsg(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}
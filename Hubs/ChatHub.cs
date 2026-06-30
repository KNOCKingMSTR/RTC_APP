using Microsoft.AspNetCore.SignalR;

namespace FormulaOne.ChatService.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        { 
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

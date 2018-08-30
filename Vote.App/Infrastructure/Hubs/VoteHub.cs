using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Vote.App.Infrastructure.Hubs
{
    public class VoteHub : Hub
    {
        public async Task JoinToGroup(string eventCode)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, eventCode);
        }
    }
}
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;

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

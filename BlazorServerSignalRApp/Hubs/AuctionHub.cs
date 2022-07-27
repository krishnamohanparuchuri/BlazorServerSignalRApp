using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Hubs
{
    public class AuctionHub : Hub
    {

        public async Task SendNewBid(int Id,decimal newBidValue)
        {
            await Clients.All.SendAsync("UpdatedBid", Id, newBidValue);
        }
    }
}

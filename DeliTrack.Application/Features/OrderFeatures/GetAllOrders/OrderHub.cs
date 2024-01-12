using DeliTrack.Application.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace DeliTrack.Application.Features.OrderFeatures.GetAllOrders;

public class OrderHub : Hub 
{
    public OrderHub() 
    {
    }

    public async Task JoinRoom(string roomName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
    }

    public async Task LeaveRoom(string roomName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
    }
}
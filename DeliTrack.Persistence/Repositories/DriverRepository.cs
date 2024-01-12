using DeliTrack.Application.Features.DriverFeatures.UpdateDriver;
using DeliTrack.Application.Features.OrderFeatures.GetAllOrders;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using DeliTrack.Persistence.Context;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Persistence.Repositories;

public class DriverPosition
{
    public Guid Id { get; set; }
    public double CurrentPosLatitude { get; set; }
    public double CurrentPosLongitude { get; set; }
}

public class DriverRepository : BaseRepository<Driver>, IDriverRepository
{
    private readonly IHubContext<OrderHub> _hubContext;
    public DriverRepository(DataContext context, IHubContext<OrderHub> hubContext) : base(context)
    {
        _hubContext = hubContext;
    }

    public async Task OnDriverPositionChange(Order order, Driver driver, CancellationToken cancellationToken)
    {
        if (order != null && driver != null)
        {
            DriverPosition driverPosition = new()
            {
                Id = driver.Id,
                CurrentPosLatitude = driver.CurrentPosLatitude,
                CurrentPosLongitude = driver.CurrentPosLongitude
            };
            await _hubContext.Clients.Group(order.Id.ToString()).SendAsync("UpdateDriverPosition", driverPosition, cancellationToken);
        }
    }
}
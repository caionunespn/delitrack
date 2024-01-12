using DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;
using DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;
using DeliTrack.Application.Features.StoreFeatures.GetAllStores;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.GetAllOrders;

public sealed record GetAllOrdersResponse
{
    public Guid Id { get; set; }
    public GetAllStoresResponse Store { get; set; } = null!;
    public GetAllCustomersResponse Customer { get; set; } = null!;
    public GetAllDriversResponse Driver { get; set; } = null!;

    public OrderStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
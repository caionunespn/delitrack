using DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;
using DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;
using DeliTrack.Application.Features.StoreFeatures.GetAllStores;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.CreateOrder;

public sealed record CreateOrderResponse
{
    public Guid Id { get; set; }
    public GetAllStoresResponse Store { get; set; } = null!;
    public GetAllCustomersResponse Customer { get; set; } = null!;
    public GetAllDriversResponse Driver { get; set; } = null!;
    public OrderStatus Status { get; set; }
}
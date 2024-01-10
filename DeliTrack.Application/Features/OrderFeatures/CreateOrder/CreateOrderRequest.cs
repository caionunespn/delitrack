using DeliTrack.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.CreateOrder;

public sealed record CreateOrderRequest(
    Guid StoreId,
    Guid CustomerId,
    Guid DriverId,
    OrderStatus Status
    ) : IRequest<CreateOrderResponse>;
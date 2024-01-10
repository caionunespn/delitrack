using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.CreateOrder;

public sealed class CreateOrderMapper : Profile
{
    public CreateOrderMapper()
    {
        CreateMap<CreateOrderRequest, Order>();
        CreateMap<Order, CreateOrderResponse>();
    }
}
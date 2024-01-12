using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.GetAllOrders;

public sealed class GetAllOrdersMapper : Profile
{
    public GetAllOrdersMapper()
    {
        CreateMap<Order, GetAllOrdersResponse>();
    }
}
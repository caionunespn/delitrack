using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;

public sealed class GetAllCustomersMapper : Profile
{
    public GetAllCustomersMapper()
    {
        CreateMap<Customer, GetAllCustomersResponse>();
    }
}
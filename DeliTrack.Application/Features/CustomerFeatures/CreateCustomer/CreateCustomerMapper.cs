using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;

public sealed class CreateCustomerMapper : Profile
{
    public CreateCustomerMapper()
    {
        CreateMap<CreateCustomerRequest, Customer>();
        CreateMap<Customer, CreateCustomerResponse>();
    }
}
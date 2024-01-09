using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliTrack.Domain.Entities;

namespace DeliTrack.Application.Features.DriverFeatures.CreateDriver;

public sealed class CreateDriverMapper : Profile
{
    public CreateDriverMapper()
    {
        CreateMap<CreateDriverRequest, Driver>();
        CreateMap<Driver, CreateDriverResponse>();
    }
}
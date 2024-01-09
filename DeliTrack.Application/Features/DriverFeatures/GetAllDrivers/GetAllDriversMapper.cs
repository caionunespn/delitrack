using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliTrack.Domain.Entities;

namespace DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;

public sealed class GetAllDriversMapper : Profile
{
    public GetAllDriversMapper()
    {
        CreateMap<Driver, GetAllDriversResponse>();
    }
}
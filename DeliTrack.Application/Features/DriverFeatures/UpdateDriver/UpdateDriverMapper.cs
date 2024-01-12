using AutoMapper;
using DeliTrack.Domain.Entities;

namespace DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

public sealed class UpdateDriverMapper : Profile
{
    public UpdateDriverMapper()
    {
        CreateMap<UpdateDriverCommand, Driver>();
        CreateMap<Driver, UpdateDriverResponse>();
    }
}
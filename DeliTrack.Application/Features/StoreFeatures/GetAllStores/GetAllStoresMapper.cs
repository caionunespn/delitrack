using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.GetAllStores;

public sealed class GetAllStoresMapper : Profile
{
    public GetAllStoresMapper()
    {
        CreateMap<Store, GetAllStoresResponse>();
    }
}
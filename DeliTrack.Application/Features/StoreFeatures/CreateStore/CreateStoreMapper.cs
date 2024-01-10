using AutoMapper;
using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.CreateStore;

public sealed class CreateStoreMapper : Profile
{
    public CreateStoreMapper()
    {
        CreateMap<CreateStoreRequest, Store>();
        CreateMap<Store, CreateStoreResponse>();
    }
}
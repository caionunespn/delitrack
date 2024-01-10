using AutoMapper;
using DeliTrack.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.GetAllStores;

public sealed class GetAllStoresHandler : IRequestHandler<GetAllStoresRequest, List<GetAllStoresResponse>>
{ 
    private readonly IStoreRepository _storeRepository;
    private readonly IMapper _mapper;

    public GetAllStoresHandler(IStoreRepository storeRepository, IMapper mapper)
    {
        _storeRepository = storeRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllStoresResponse>> Handle(GetAllStoresRequest request, CancellationToken cancellationToken)
    {
        var stores = await _storeRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllStoresResponse>>(stores);
    }
}
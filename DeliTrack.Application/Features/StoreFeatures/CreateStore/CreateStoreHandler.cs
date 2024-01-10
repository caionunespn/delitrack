using AutoMapper;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.CreateStore;

public sealed class CreateStoreHandler : IRequestHandler<CreateStoreRequest, CreateStoreResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStoreRepository _storeRepository;
    private readonly IMapper _mapper;

    public CreateStoreHandler(IUnitOfWork unitOfWork, IStoreRepository storeRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _storeRepository = storeRepository;
        _mapper = mapper;
    }

    public async Task<CreateStoreResponse> Handle(CreateStoreRequest request, CancellationToken cancellationToken)
    {
        var store = _mapper.Map<Store>(request);
        _storeRepository.Create(store);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateStoreResponse>(store);
    }
}
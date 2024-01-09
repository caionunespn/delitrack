using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;

public sealed class GetAllDriversHandler : IRequestHandler<GetAllDriversRequest, List<GetAllDriversResponse>>
{
    private readonly IDriverRepository _driverRepository;
    private readonly IMapper _mapper;

    public GetAllDriversHandler(IDriverRepository driverRepository, IMapper mapper)
    {
        _driverRepository = driverRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllDriversResponse>> Handle(GetAllDriversRequest request, CancellationToken cancellationToken)
    {
        var drivers = await _driverRepository.GetAll(cancellationToken);

        return _mapper.Map<List<GetAllDriversResponse>>(drivers);
    }
}
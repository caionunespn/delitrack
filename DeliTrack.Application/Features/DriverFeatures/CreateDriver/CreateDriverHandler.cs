using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.DriverFeatures.CreateDriver;

public sealed class CreateDriverHandler : IRequestHandler<CreateDriverRequest, CreateDriverResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDriverRepository _driverRepository;
    private readonly IMapper _mapper;

    public CreateDriverHandler(IUnitOfWork unitOfWork, IDriverRepository driverRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _driverRepository = driverRepository;
        _mapper = mapper;
    }

    public async Task<CreateDriverResponse> Handle(CreateDriverRequest request, CancellationToken cancellationToken)
    {
        var driver = _mapper.Map<Driver>(request);
        _driverRepository.Create(driver);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateDriverResponse>(driver);
    }
}
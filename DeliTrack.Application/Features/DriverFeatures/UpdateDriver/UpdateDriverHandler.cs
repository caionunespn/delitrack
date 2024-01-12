using AutoMapper;
using DeliTrack.Application.Common.Exceptions;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

public sealed class UpdateDriverHandler : IRequestHandler<UpdateDriverCommand, UpdateDriverResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDriverRepository _driverRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public UpdateDriverHandler(IUnitOfWork unitOfWork, IDriverRepository driverRepository, IOrderRepository orderRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _driverRepository = driverRepository;
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<UpdateDriverResponse> Handle(UpdateDriverCommand request, CancellationToken cancellationToken)
    {
        var driver = _mapper.Map<Driver>(request);
        _driverRepository.Update(driver);
        await _unitOfWork.Save(cancellationToken);

        var orders = await _orderRepository.GetOrdersByDriver(driver.Id, cancellationToken);

        foreach (var order in orders)
        {
            _driverRepository.OnDriverPositionChange(order, driver, cancellationToken);
        }

        return _mapper.Map<UpdateDriverResponse>(driver);
    }
}
using AutoMapper;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.CreateOrder;

public sealed class CreateOrderHandler : IRequestHandler<CreateOrderRequest, CreateOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOrderRepository _orderRepository;
    private readonly IStoreRepository _storeRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IDriverRepository _driverRepository;
    private readonly IMapper _mapper;

    public CreateOrderHandler(
        IUnitOfWork unitOfWork, 
        IOrderRepository orderRepository, 
        IStoreRepository storeRepository, 
        ICustomerRepository customerRepository, 
        IDriverRepository driverRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _orderRepository = orderRepository;
        _storeRepository = storeRepository;
        _customerRepository = customerRepository;
        _driverRepository = driverRepository;
        _mapper = mapper;
    }

    public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var order = _mapper.Map<Order>(request);

        var store = await _storeRepository.Get(order.StoreId, cancellationToken);
        var customer = await _customerRepository.Get(order.CustomerId, cancellationToken);
        var driver = await _driverRepository.Get(order.DriverId, cancellationToken);

        order.Store = store;
        order.Customer = customer;
        order.Driver = driver;

        _orderRepository.Create(order);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateOrderResponse>(order);
    }
}
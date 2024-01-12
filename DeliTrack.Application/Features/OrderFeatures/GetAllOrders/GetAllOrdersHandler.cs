using AutoMapper;
using DeliTrack.Application.Features.OrderFeatures.GetAllOrders;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.GetOrders;

public sealed class GetAllOrdersHandler : IRequestHandler<GetAllOrdersRequest, List<GetAllOrdersResponse>>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IStoreRepository _storeRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IDriverRepository _driverRepository;
    private readonly IMapper _mapper;

    public GetAllOrdersHandler(IOrderRepository orderRepository, IStoreRepository storeRepository, ICustomerRepository customerRepository, IDriverRepository driverRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _storeRepository = storeRepository;
        _customerRepository = customerRepository;
        _driverRepository = driverRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllOrdersResponse>> Handle(GetAllOrdersRequest request, CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetAll(cancellationToken);

        foreach(var order in orders)
        {
            var store = await _storeRepository.Get(order.StoreId, cancellationToken);
            var customer = await _customerRepository.Get(order.CustomerId, cancellationToken);
            var driver = await _driverRepository.Get(order.DriverId, cancellationToken);

            order.Store = store;
            order.Customer = customer;
            order.Driver = driver;
        }

        return _mapper.Map<List<GetAllOrdersResponse>>(orders);
    }
}
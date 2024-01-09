using AutoMapper;
using DeliTrack.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;

public sealed class GetAllCustomersHandler : IRequestHandler<GetAllCustomersRequest, List<GetAllCustomersResponse>>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetAllCustomersHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllCustomersResponse>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetAll(cancellationToken);

        return _mapper.Map<List<GetAllCustomersResponse>>(customers);
    }
}
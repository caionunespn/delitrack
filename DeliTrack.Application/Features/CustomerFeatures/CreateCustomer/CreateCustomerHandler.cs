using AutoMapper;
using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;

public sealed class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CreateCustomerHandler(IUnitOfWork unitOfWork, ICustomerRepository customerRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var customer = _mapper.Map<Customer>(request);
        _customerRepository.Create(customer);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateCustomerResponse>(customer);
    }
}
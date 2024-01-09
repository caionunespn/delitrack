using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;

public sealed record CreateCustomerRequest(
    string Email,
    string Name,
    string Address,
    string City,
    string State,
    string PostalCode,
    string Country,
    string Phone,
    double CurrentPosLatitude,
    double CurrentPosLongitude
    ) : IRequest<CreateCustomerResponse>;
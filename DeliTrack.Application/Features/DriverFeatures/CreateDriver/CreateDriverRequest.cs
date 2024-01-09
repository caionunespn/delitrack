using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DeliTrack.Application.Features.DriverFeatures.CreateDriver;

public sealed record CreateDriverRequest(
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
    ) : IRequest<CreateDriverResponse>;
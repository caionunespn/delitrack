using MediatR;

namespace DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

public sealed record UpdateDriverRequest(
    string Email,
    bool ShowPosition,
    string Name,
    string Address,
    string City,
    string State,
    string PostalCode,
    string Country,
    string Phone,
    double CurrentPosLatitude,
    double CurrentPosLongitude
);

public sealed record UpdateDriverCommand(
    Guid Id,
    string Email,
    bool ShowPosition,
    string Name,
    string Address,
    string City,
    string State,
    string PostalCode,
    string Country,
    string Phone,
    double CurrentPosLatitude,
    double CurrentPosLongitude
) : IRequest<UpdateDriverResponse>;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;

public sealed record GetAllDriversRequest : IRequest<List<GetAllDriversResponse>>;
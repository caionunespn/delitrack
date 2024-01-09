using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;

public sealed record GetAllCustomersRequest : IRequest<List<GetAllCustomersResponse>>;
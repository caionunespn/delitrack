using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.OrderFeatures.GetAllOrders;

public sealed record GetAllOrdersRequest : IRequest<List<GetAllOrdersResponse>>;
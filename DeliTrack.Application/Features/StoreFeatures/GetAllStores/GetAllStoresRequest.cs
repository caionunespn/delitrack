using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.GetAllStores;

public sealed record GetAllStoresRequest : IRequest<List<GetAllStoresResponse>>;
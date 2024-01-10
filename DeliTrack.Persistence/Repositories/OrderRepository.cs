using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using DeliTrack.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Persistence.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(DataContext context) : base(context) { }

    public Task<Order> GetPositions(Guid id, CancellationToken cancellationToken)
    {
        return null;
    }
}
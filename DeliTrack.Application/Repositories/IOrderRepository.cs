using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Repositories;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<Order> GetPositions(Guid id, CancellationToken cancellationToken);
}
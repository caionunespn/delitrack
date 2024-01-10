using DeliTrack.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Domain.Entities;

public class Order : BaseEntity
{
    public Guid StoreId { get; set; }
    public Store Store { get; set; } = null!;
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public Guid DriverId { get; set; }
    public Driver Driver { get; set; } = null!;

    public OrderStatus Status { get; set; } = OrderStatus.ORDERED;

}
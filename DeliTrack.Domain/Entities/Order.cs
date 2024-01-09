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
    public Guid CustomerId { get; set; }
    public Guid DriverId { get; set; }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Domain.Entities;

public enum OrderStatus
{
    ORDERED = 1,
    CONFIRMED = 2,
    PREPARTION = 3,
    DELIVERY = 4,
    DELIVERED = 5,
    CANCELLED = 6,
}
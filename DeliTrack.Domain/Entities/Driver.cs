using DeliTrack.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Domain.Entities;

public class Driver : Entity
{
    public string Email { get; set; }
    public bool ShowPosition { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();
}
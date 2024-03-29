﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliTrack.Domain.Common;

namespace DeliTrack.Domain.Entities;

public class Customer : Entity
{
    public string Email { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();
}
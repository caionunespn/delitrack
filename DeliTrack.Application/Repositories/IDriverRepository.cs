﻿using DeliTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Repositories;

public interface IDriverRepository : IBaseRepository<Driver>
{
    Task OnDriverPositionChange(Order order, Driver driver, CancellationToken cancellationToken);
}
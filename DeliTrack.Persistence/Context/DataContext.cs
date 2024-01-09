using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliTrack.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
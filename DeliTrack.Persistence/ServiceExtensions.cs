using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliTrack.Persistence.Context;
using DeliTrack.Persistence.Repositories;
using DeliTrack.Application.Repositories;

namespace DeliTrack.Persistence;

public static class ServiceExtensions
{ 
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");
        services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IDriverRepository, DriverRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IStoreRepository, StoreRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
    }
}
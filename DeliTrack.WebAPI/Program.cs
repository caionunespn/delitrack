using DeliTrack.Application;
using DeliTrack.Application.Features.OrderFeatures.GetAllOrders;
using DeliTrack.Persistence;
using DeliTrack.Persistence.Context;
using DeliTrack.WebAPI.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();

builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
await dataContext?.Database.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(x => x
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true)
        .AllowCredentials());
}

app.UseErrorHandler();
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<OrderHub>("/order");

app.Run();

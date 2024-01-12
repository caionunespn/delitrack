using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;

public sealed record GetAllCustomersResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public double CurrentPosLatitude { get; set; }
    public double CurrentPosLongitude { get; set; }
}
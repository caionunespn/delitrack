using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;

public sealed record GetAllDriversResponse
{ 
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public bool ShowPosition { get; set; }
    public double CurrentPosLatitude { get; set; }
    public double CurrentPosLongitude { get; set; }
}
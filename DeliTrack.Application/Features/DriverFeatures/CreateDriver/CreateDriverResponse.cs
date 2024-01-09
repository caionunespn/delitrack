using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.DriverFeatures.CreateDriver;

public sealed record CreateDriverResponse
{ 
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}
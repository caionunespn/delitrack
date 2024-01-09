using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;

public sealed record CreateCustomerResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}
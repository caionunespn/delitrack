using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;

public sealed class CreateCustomer : AbstractValidator<CreateCustomerRequest>
{
    public void CreateCustomerValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(100);
    }
}
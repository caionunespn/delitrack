using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DeliTrack.Application.Features.DriverFeatures.CreateDriver;

public sealed class CreateDriverValidator : AbstractValidator<CreateDriverRequest>
{
    public CreateDriverValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(100);
    }
}
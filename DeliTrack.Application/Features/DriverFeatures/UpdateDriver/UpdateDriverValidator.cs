
using System.Data;
using FluentValidation;

namespace DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

public sealed class UpdateDriverValidator : AbstractValidator<UpdateDriverRequest>
{
    public UpdateDriverValidator()
    {
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(100);
    }
}
using DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Application.Features.StoreFeatures.CreateStore;

public sealed class CreateStoreValidator : AbstractValidator<CreateStoreRequest>
{
    public CreateStoreValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(100);
    }
}
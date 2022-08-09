using FluentValidation;
using Radency.Contracts.DTO;

namespace Radency.Core.Validators
{
    public class AddRaitingValidator : AbstractValidator<AddRaitingDTO>
    {
        public AddRaitingValidator()
        {
            RuleFor(x => x.Score)
                .NotEmpty()
                .NotNull()
                .Must((model, score) => score >= 1 && score <= 5)
                .WithMessage("Rating can be from 1 to 5");
        }
    }
}

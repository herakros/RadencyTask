using FluentValidation;
using Radency.Contracts.DTO;

namespace Radency.Core.Validators
{
    public class CreateOrUpdateBookValidator : AbstractValidator<CreateOrUpdateBookDTO>
    {
        public CreateOrUpdateBookValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MaximumLength(30);
            RuleFor(x => x.Cover).NotNull().NotEmpty();
            RuleFor(x => x.Content).NotNull().NotEmpty();
            RuleFor(x => x.Genre).NotNull().NotEmpty().MaximumLength(30);
            RuleFor(x => x.Author).NotNull().NotEmpty().MaximumLength(60);
        }
    }
}

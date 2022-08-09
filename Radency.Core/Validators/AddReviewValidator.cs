using FluentValidation;
using Radency.Contracts.DTO;

namespace Radency.Core.Validators
{
    public class AddReviewValidator : AbstractValidator<AddReviewDTO>
    {
        public AddReviewValidator()
        {
            RuleFor(x => x.Message).NotNull().NotEmpty();
            RuleFor(x => x.Reviewer).NotNull().NotEmpty().MaximumLength(60);
        }
    }
}


using FluentValidation;

namespace BookStore.Application.Features.BookFeatures.CreateBook
{
    public sealed class CreateBookValidator : AbstractValidator<CreateBookRequest>
    {
        public CreateBookValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().MinimumLength(5).MaximumLength(100);
            RuleFor(x => x.Description).MaximumLength(300);
            RuleFor(x => x.Author).NotEmpty().MaximumLength(100);
        }
    }
}

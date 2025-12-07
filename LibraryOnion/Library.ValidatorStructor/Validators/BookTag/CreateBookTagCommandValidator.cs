using FluentValidation;
using Library.Application.Commands.BookTag;

namespace Library.ValidatorStructor.Validators.BookTag
{
    public class CreateBookTagCommandValidator : AbstractValidator<CreateBookTagCommand>
    {
        public CreateBookTagCommandValidator()
        {
            RuleFor(x => x.BookId)
                .GreaterThan(0).WithMessage("Book ID must be greater than 0");
            
            RuleFor(x => x.TagId)
                .GreaterThan(0).WithMessage("Tag ID must be greater than 0");
        }
    }
}


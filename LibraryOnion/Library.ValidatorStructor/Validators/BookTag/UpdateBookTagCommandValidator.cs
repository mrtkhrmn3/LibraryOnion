using FluentValidation;
using Library.Application.Commands.BookTag;

namespace Library.ValidatorStructor.Validators.BookTag
{
    public class UpdateBookTagCommandValidator : AbstractValidator<UpdateBookTagCommand>
    {
        public UpdateBookTagCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id must be greater than 0");
            
            RuleFor(x => x.BookId)
                .GreaterThan(0).WithMessage("Book ID must be greater than 0");
            
            RuleFor(x => x.TagId)
                .GreaterThan(0).WithMessage("Tag ID must be greater than 0");
        }
    }
}


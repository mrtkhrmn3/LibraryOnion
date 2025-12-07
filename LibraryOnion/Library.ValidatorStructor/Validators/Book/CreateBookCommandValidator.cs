using FluentValidation;
using Library.Application.Commands.Book;

namespace Library.ValidatorStructor.Validators.Book
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characters");
            
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Category ID must be greater than 0");
            
            RuleFor(x => x.AuthorId)
                .GreaterThan(0).WithMessage("Author ID must be greater than 0");
        }
    }
}


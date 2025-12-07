using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Book
{
    public class CreateBookCommand : ICommand<BookDto>
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}


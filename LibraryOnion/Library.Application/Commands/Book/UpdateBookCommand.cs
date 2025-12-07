using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Book
{
    public class UpdateBookCommand : ICommand<BookDto>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}


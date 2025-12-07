using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.BookTag
{
    public class CreateBookTagCommand : ICommand<BookTagDto>
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}


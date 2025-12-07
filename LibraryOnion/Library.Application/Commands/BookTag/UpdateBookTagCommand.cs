using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.BookTag
{
    public class UpdateBookTagCommand : ICommand<BookTagDto>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}


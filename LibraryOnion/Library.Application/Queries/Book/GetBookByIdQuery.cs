using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Queries.Book
{
    public class GetBookByIdQuery : IQuery<BookDto>
    {
        public int Id { get; set; }
    }
}


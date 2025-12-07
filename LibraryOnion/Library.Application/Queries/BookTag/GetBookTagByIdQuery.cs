using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Queries.BookTag
{
    public class GetBookTagByIdQuery : IQuery<BookTagDto>
    {
        public int Id { get; set; }
    }
}


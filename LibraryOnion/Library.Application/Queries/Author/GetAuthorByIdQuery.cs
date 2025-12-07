using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Queries.Author
{
    public class GetAuthorByIdQuery : IQuery<AuthorDto>
    {
        public int Id { get; set; }
    }
}


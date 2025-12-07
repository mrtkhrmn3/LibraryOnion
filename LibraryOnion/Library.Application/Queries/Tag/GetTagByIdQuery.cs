using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Queries.Tag
{
    public class GetTagByIdQuery : IQuery<TagDto>
    {
        public int Id { get; set; }
    }
}


using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Queries.Category
{
    public class GetCategoryByIdQuery : IQuery<CategoryDto>
    {
        public int Id { get; set; }
    }
}


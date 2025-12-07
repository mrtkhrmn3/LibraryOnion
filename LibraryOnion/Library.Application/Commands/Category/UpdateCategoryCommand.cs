using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Category
{
    public class UpdateCategoryCommand : ICommand<CategoryDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


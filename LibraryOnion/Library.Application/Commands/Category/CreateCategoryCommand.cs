using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Category
{
    public class CreateCategoryCommand : ICommand<CategoryDto>
    {
        public string Name { get; set; }
    }
}


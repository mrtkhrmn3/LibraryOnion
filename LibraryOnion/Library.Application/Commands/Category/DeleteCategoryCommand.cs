using Library.Application;

namespace Library.Application.Commands.Category
{
    public class DeleteCategoryCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}


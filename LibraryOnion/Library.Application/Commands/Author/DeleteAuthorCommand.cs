using Library.Application;

namespace Library.Application.Commands.Author
{
    public class DeleteAuthorCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}

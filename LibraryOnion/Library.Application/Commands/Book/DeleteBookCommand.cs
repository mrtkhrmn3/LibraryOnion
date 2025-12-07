using Library.Application;

namespace Library.Application.Commands.Book
{
    public class DeleteBookCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}


using Library.Application;

namespace Library.Application.Commands.BookTag
{
    public class DeleteBookTagCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}


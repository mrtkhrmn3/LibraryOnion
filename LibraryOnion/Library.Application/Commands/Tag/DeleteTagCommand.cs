using Library.Application;

namespace Library.Application.Commands.Tag
{
    public class DeleteTagCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}


using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Author
{
    public class CreateAuthorCommand : ICommand<AuthorDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

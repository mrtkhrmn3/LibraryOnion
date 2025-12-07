using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Author
{
    public class UpdateAuthorCommand : ICommand<AuthorDto>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

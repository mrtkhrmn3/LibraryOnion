using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Tag
{
    public class UpdateTagCommand : ICommand<TagDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


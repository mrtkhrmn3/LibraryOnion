using Library.Application;
using Library.Application.DTOs;

namespace Library.Application.Commands.Tag
{
    public class CreateTagCommand : ICommand<TagDto>
    {
        public string Name { get; set; }
    }
}


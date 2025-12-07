using AutoMapper;
using Library.Application.Commands.Author;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Author
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, AuthorDto>
    {
        private readonly IAuthorManager _authorManager;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorManager authorManager, IMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var authorDto = _mapper.Map<AuthorDto>(request);
            await _authorManager.CreateAsync(authorDto);
            return authorDto;
        }
    }
}

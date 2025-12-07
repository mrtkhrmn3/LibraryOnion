using AutoMapper;
using Library.Application.Commands.Author;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Author
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, AuthorDto>
    {
        private readonly IAuthorManager _authorManager;
        private readonly IMapper _mapper;

        public UpdateAuthorCommandHandler(IAuthorManager authorManager, IMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var authorDto = _mapper.Map<AuthorDto>(request);
            await _authorManager.UpdateAsync(authorDto);
            return authorDto;
        }
    }
}

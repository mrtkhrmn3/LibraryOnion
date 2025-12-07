using AutoMapper;
using Library.Application.Commands.Tag;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Tag
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, TagDto>
    {
        private readonly ITagManager _tagManager;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(ITagManager tagManager, IMapper mapper)
        {
            _tagManager = tagManager;
            _mapper = mapper;
        }

        public async Task<TagDto> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var tagDto = _mapper.Map<TagDto>(request);
            await _tagManager.CreateAsync(tagDto);
            return tagDto;
        }
    }
}


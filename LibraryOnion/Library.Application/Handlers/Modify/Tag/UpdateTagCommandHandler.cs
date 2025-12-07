using AutoMapper;
using Library.Application.Commands.Tag;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Tag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, TagDto>
    {
        private readonly ITagManager _tagManager;
        private readonly IMapper _mapper;

        public UpdateTagCommandHandler(ITagManager tagManager, IMapper mapper)
        {
            _tagManager = tagManager;
            _mapper = mapper;
        }

        public async Task<TagDto> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var tagDto = _mapper.Map<TagDto>(request);
            await _tagManager.UpdateAsync(tagDto);
            return tagDto;
        }
    }
}


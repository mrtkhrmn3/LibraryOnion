using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Tag;
using MediatR;

namespace Library.Application.Handlers.Read.Tag
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, TagDto>
    {
        private readonly ITagManager _tagManager;

        public GetTagByIdQueryHandler(ITagManager tagManager)
        {
            _tagManager = tagManager;
        }

        public async Task<TagDto> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            return await _tagManager.GetByIdAsync(request.Id);
        }
    }
}


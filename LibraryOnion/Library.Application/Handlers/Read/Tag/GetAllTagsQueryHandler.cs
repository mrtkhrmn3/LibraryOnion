using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Tag;
using MediatR;

namespace Library.Application.Handlers.Read.Tag
{
    public class GetAllTagsQueryHandler : IRequestHandler<GetAllTagsQuery, List<TagDto>>
    {
        private readonly ITagManager _tagManager;

        public GetAllTagsQueryHandler(ITagManager tagManager)
        {
            _tagManager = tagManager;
        }

        public async Task<List<TagDto>> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
        {
            return await _tagManager.GetAllAsync();
        }
    }
}


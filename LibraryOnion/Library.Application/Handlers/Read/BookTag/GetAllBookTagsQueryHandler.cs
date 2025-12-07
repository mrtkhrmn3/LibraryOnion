using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.BookTag;
using MediatR;

namespace Library.Application.Handlers.Read.BookTag
{
    public class GetAllBookTagsQueryHandler : IRequestHandler<GetAllBookTagsQuery, List<BookTagDto>>
    {
        private readonly IBookTagManager _bookTagManager;

        public GetAllBookTagsQueryHandler(IBookTagManager bookTagManager)
        {
            _bookTagManager = bookTagManager;
        }

        public async Task<List<BookTagDto>> Handle(GetAllBookTagsQuery request, CancellationToken cancellationToken)
        {
            return await _bookTagManager.GetAllAsync();
        }
    }
}


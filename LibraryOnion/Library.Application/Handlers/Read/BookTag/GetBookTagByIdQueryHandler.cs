using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.BookTag;
using MediatR;

namespace Library.Application.Handlers.Read.BookTag
{
    public class GetBookTagByIdQueryHandler : IRequestHandler<GetBookTagByIdQuery, BookTagDto>
    {
        private readonly IBookTagManager _bookTagManager;

        public GetBookTagByIdQueryHandler(IBookTagManager bookTagManager)
        {
            _bookTagManager = bookTagManager;
        }

        public async Task<BookTagDto> Handle(GetBookTagByIdQuery request, CancellationToken cancellationToken)
        {
            return await _bookTagManager.GetByIdAsync(request.Id);
        }
    }
}


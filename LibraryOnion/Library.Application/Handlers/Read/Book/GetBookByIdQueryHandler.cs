using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Book;
using MediatR;

namespace Library.Application.Handlers.Read.Book
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDto>
    {
        private readonly IBookManager _bookManager;

        public GetBookByIdQueryHandler(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<BookDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return await _bookManager.GetByIdAsync(request.Id);
        }
    }
}


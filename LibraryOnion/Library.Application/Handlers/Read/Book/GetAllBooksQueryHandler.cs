using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Book;
using MediatR;

namespace Library.Application.Handlers.Read.Book
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IBookManager _bookManager;

        public GetAllBooksQueryHandler(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await _bookManager.GetAllAsync();
        }
    }
}


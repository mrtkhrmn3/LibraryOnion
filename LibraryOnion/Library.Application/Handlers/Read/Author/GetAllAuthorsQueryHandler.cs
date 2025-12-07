using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Author;
using MediatR;

namespace Library.Application.Handlers.Read.Author
{
    public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, List<AuthorDto>>
    {
        private readonly IAuthorManager _authorManager;

        public GetAllAuthorsQueryHandler(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        public async Task<List<AuthorDto>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            return await _authorManager.GetAllAsync();
        }
    }
}

using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Author;
using MediatR;

namespace Library.Application.Handlers.Read.Author
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, AuthorDto>
    {
        private readonly IAuthorManager _authorManager;

        public GetAuthorByIdQueryHandler(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        public async Task<AuthorDto> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            return await _authorManager.GetByIdAsync(request.Id);
        }
    }
}

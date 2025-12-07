using Library.Application.Commands.Author;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Author
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, bool>
    {
        private readonly IAuthorManager _authorManager;

        public DeleteAuthorCommandHandler(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        public async Task<bool> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var result = await _authorManager.SoftDeleteAsync(request.Id);
            return !string.IsNullOrEmpty(result);
        }
    }
}

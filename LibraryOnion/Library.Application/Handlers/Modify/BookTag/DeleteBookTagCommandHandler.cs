using Library.Application.Commands.BookTag;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.BookTag
{
    public class DeleteBookTagCommandHandler : IRequestHandler<DeleteBookTagCommand, bool>
    {
        private readonly IBookTagManager _bookTagManager;

        public DeleteBookTagCommandHandler(IBookTagManager bookTagManager)
        {
            _bookTagManager = bookTagManager;
        }

        public async Task<bool> Handle(DeleteBookTagCommand request, CancellationToken cancellationToken)
        {
            var result = await _bookTagManager.SoftDeleteAsync(request.Id);
            return !string.IsNullOrEmpty(result);
        }
    }
}


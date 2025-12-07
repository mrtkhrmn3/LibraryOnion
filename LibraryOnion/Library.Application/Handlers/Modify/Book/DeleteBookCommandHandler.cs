using Library.Application.Commands.Book;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Book
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
    {
        private readonly IBookManager _bookManager;

        public DeleteBookCommandHandler(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var result = await _bookManager.SoftDeleteAsync(request.Id);
            return !string.IsNullOrEmpty(result);
        }
    }
}


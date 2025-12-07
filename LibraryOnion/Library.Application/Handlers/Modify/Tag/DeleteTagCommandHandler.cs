using Library.Application.Commands.Tag;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Tag
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand, bool>
    {
        private readonly ITagManager _tagManager;

        public DeleteTagCommandHandler(ITagManager tagManager)
        {
            _tagManager = tagManager;
        }

        public async Task<bool> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var result = await _tagManager.SoftDeleteAsync(request.Id);
            return !string.IsNullOrEmpty(result);
        }
    }
}


using Library.Application.Commands.Category;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Category
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly ICategoryManager _categoryManager;

        public DeleteCategoryCommandHandler(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _categoryManager.SoftDeleteAsync(request.Id);
            return !string.IsNullOrEmpty(result);
        }
    }
}


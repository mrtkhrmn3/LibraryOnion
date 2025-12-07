using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Category;
using MediatR;

namespace Library.Application.Handlers.Read.Category
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CategoryDto>
    {
        private readonly ICategoryManager _categoryManager;

        public GetCategoryByIdQueryHandler(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<CategoryDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _categoryManager.GetByIdAsync(request.Id);
        }
    }
}


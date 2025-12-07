using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Application.Queries.Category;
using MediatR;

namespace Library.Application.Handlers.Read.Category
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryDto>>
    {
        private readonly ICategoryManager _categoryManager;

        public GetAllCategoriesQueryHandler(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<List<CategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoryManager.GetAllAsync();
        }
    }
}


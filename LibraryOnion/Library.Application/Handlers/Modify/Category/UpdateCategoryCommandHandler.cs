using AutoMapper;
using Library.Application.Commands.Category;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Category
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, CategoryDto>
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryManager categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryDto = _mapper.Map<CategoryDto>(request);
            await _categoryManager.UpdateAsync(categoryDto);
            return categoryDto;
        }
    }
}


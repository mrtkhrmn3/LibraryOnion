using AutoMapper;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public class CategoryManager : BaseManager<CategoryDto, Category>, ICategoryManager
    {
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper) 
            : base(categoryRepository, mapper)
        {
        }
    }
}


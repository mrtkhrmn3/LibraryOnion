using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using Library.Presistence.ContextClasses;

namespace Library.Presistence.RepositoryConcretes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}


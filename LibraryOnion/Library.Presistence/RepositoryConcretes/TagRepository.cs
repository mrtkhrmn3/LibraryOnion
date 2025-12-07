using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using Library.Presistence.ContextClasses;

namespace Library.Presistence.RepositoryConcretes
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}


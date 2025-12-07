using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using Library.Presistence.ContextClasses;

namespace Library.Presistence.RepositoryConcretes
{
    public class BookTagRepository : BaseRepository<BookTag>, IBookTagRepository
    {
        public BookTagRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}


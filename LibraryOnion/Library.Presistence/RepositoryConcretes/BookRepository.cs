using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using Library.Presistence.ContextClasses;

namespace Library.Presistence.RepositoryConcretes
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}


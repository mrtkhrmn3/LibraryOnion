using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using Library.Presistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presistence.RepositoryConcretes
{
    public class AuthorRepository(LibraryDbContext context) : BaseRepository<Author>(context),IAuthorRepository
    {
    }
}

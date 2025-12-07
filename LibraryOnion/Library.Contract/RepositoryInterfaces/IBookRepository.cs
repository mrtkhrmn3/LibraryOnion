using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contract.RepositoryInterfaces
{
    public interface IBookRepository : IRepository<Book>
    {
    }
}

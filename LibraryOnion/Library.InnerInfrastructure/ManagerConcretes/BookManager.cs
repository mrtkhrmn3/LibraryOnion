using AutoMapper;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public class BookManager : BaseManager<BookDto, Book>, IBookManager
    {
        public BookManager(IBookRepository bookRepository, IMapper mapper) 
            : base(bookRepository, mapper)
        {
        }
    }
}


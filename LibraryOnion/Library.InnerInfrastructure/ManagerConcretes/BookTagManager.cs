using AutoMapper;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public class BookTagManager : BaseManager<BookTagDto, BookTag>, IBookTagManager
    {
        public BookTagManager(IBookTagRepository bookTagRepository, IMapper mapper) 
            : base(bookTagRepository, mapper)
        {
        }
    }
}


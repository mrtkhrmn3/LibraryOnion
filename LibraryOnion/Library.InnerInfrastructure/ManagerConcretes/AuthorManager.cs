using AutoMapper;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public class AuthorManager : BaseManager<AuthorDto, Author>, IAuthorManager
    {
        public AuthorManager(IAuthorRepository authorRepository, IMapper mapper) 
            : base(authorRepository, mapper)
        {
        }
    }
}

using AutoMapper;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public class TagManager : BaseManager<TagDto, Tag>, ITagManager
    {
        public TagManager(ITagRepository tagRepository, IMapper mapper) 
            : base(tagRepository, mapper)
        {
        }
    }
}


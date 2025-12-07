using AutoMapper;
using Library.Application.Commands.Author;
using Library.Application.Commands.Book;
using Library.Application.Commands.BookTag;
using Library.Application.Commands.Category;
using Library.Application.Commands.Tag;
using Library.Application.DTOs;
using Library.Domain.Entities;

namespace Library.Application.MappingProfiles
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Firstname))
                .ReverseMap()
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => src.FirstName));

            CreateMap<CreateAuthorCommand, AuthorDto>();
            CreateMap<UpdateAuthorCommand, AuthorDto>();

            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<CreateBookCommand, BookDto>();
            CreateMap<UpdateBookCommand, BookDto>();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryCommand, CategoryDto>();
            CreateMap<UpdateCategoryCommand, CategoryDto>();

            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<CreateTagCommand, TagDto>();
            CreateMap<UpdateTagCommand, TagDto>();

            CreateMap<BookTag, BookTagDto>().ReverseMap();
            CreateMap<CreateBookTagCommand, BookTagDto>();
            CreateMap<UpdateBookTagCommand, BookTagDto>();
        }
    }
}

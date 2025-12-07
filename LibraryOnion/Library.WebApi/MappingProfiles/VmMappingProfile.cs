using AutoMapper;
using Library.Application.Commands.Author;
using Library.Application.Commands.Book;
using Library.Application.Commands.BookTag;
using Library.Application.Commands.Category;
using Library.Application.Commands.Tag;
using Library.Application.DTOs;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;

namespace Library.WebApi.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateAuthorRequestModel, AuthorDto>();
            CreateMap<UpdateAuthorRequestModel, AuthorDto>();
            CreateMap<CreateAuthorRequestModel, CreateAuthorCommand>();
            CreateMap<UpdateAuthorRequestModel, UpdateAuthorCommand>();
            CreateMap<AuthorDto, AuthorResponseModel>();

            CreateMap<CreateBookRequestModel, BookDto>();
            CreateMap<UpdateBookRequestModel, BookDto>();
            CreateMap<CreateBookRequestModel, CreateBookCommand>();
            CreateMap<UpdateBookRequestModel, UpdateBookCommand>();
            CreateMap<BookDto, BookResponseModel>();

            CreateMap<CreateCategoryRequestModel, CategoryDto>();
            CreateMap<UpdateCategoryRequestModel, CategoryDto>();
            CreateMap<CreateCategoryRequestModel, CreateCategoryCommand>();
            CreateMap<UpdateCategoryRequestModel, UpdateCategoryCommand>();
            CreateMap<CategoryDto, CategoryResponseModel>();

            CreateMap<CreateTagRequestModel, TagDto>();
            CreateMap<UpdateTagRequestModel, TagDto>();
            CreateMap<CreateTagRequestModel, CreateTagCommand>();
            CreateMap<UpdateTagRequestModel, UpdateTagCommand>();
            CreateMap<TagDto, TagResponseModel>();

            CreateMap<CreateBookTagRequestModel, BookTagDto>();
            CreateMap<UpdateBookTagRequestModel, BookTagDto>();
            CreateMap<CreateBookTagRequestModel, CreateBookTagCommand>();
            CreateMap<UpdateBookTagRequestModel, UpdateBookTagCommand>();
            CreateMap<BookTagDto, BookTagResponseModel>();
        }
    }
}

using Library.Application.DTOs;
using Library.Domain.Entities;

namespace Library.Application.ManagerInterfaces
{
    public interface IBookManager : IManager<BookDto, Book>
    {
    }
}

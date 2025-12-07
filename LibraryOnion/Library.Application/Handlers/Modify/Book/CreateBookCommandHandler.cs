using AutoMapper;
using Library.Application.Commands.Book;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Book
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookDto>
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;

        public CreateBookCommandHandler(IBookManager bookManager, IMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }

        public async Task<BookDto> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var bookDto = _mapper.Map<BookDto>(request);
            await _bookManager.CreateAsync(bookDto);
            return bookDto;
        }
    }
}


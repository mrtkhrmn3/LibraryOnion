using AutoMapper;
using Library.Application.Commands.Book;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.Book
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, BookDto>
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(IBookManager bookManager, IMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }

        public async Task<BookDto> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var bookDto = _mapper.Map<BookDto>(request);
            await _bookManager.UpdateAsync(bookDto);
            return bookDto;
        }
    }
}


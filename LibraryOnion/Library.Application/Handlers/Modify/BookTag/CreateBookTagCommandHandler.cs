using AutoMapper;
using Library.Application.Commands.BookTag;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.BookTag
{
    public class CreateBookTagCommandHandler : IRequestHandler<CreateBookTagCommand, BookTagDto>
    {
        private readonly IBookTagManager _bookTagManager;
        private readonly IMapper _mapper;

        public CreateBookTagCommandHandler(IBookTagManager bookTagManager, IMapper mapper)
        {
            _bookTagManager = bookTagManager;
            _mapper = mapper;
        }

        public async Task<BookTagDto> Handle(CreateBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTagDto = _mapper.Map<BookTagDto>(request);
            await _bookTagManager.CreateAsync(bookTagDto);
            return bookTagDto;
        }
    }
}


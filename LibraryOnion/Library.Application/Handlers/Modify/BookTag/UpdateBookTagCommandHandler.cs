using AutoMapper;
using Library.Application.Commands.BookTag;
using Library.Application.DTOs;
using Library.Application.ManagerInterfaces;
using MediatR;

namespace Library.Application.Handlers.Modify.BookTag
{
    public class UpdateBookTagCommandHandler : IRequestHandler<UpdateBookTagCommand, BookTagDto>
    {
        private readonly IBookTagManager _bookTagManager;
        private readonly IMapper _mapper;

        public UpdateBookTagCommandHandler(IBookTagManager bookTagManager, IMapper mapper)
        {
            _bookTagManager = bookTagManager;
            _mapper = mapper;
        }

        public async Task<BookTagDto> Handle(UpdateBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTagDto = _mapper.Map<BookTagDto>(request);
            await _bookTagManager.UpdateAsync(bookTagDto);
            return bookTagDto;
        }
    }
}


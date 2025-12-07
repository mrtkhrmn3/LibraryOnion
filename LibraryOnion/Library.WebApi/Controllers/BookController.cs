using AutoMapper;
using Library.Application.Commands.Book;
using Library.Application.Queries.Book;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BookController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookResponseModel>>> GetAll()
        {
            var query = new GetAllBooksQuery();
            var result = await _mediator.Send(query);
            var response = _mapper.Map<List<BookResponseModel>>(result);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookResponseModel>> GetById(int id)
        {
            var query = new GetBookByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            var response = _mapper.Map<BookResponseModel>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<BookResponseModel>> Create([FromBody] CreateBookRequestModel requestModel)
        {
            var command = _mapper.Map<CreateBookCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<BookResponseModel>(result);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<BookResponseModel>> Update([FromBody] UpdateBookRequestModel requestModel)
        {
            var command = _mapper.Map<UpdateBookCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<BookResponseModel>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteBookCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}


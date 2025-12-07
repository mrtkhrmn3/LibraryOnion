using AutoMapper;
using Library.Application.Commands.BookTag;
using Library.Application.Queries.BookTag;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTagController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BookTagController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookTagResponseModel>>> GetAll()
        {
            var query = new GetAllBookTagsQuery();
            var result = await _mediator.Send(query);
            var response = _mapper.Map<List<BookTagResponseModel>>(result);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookTagResponseModel>> GetById(int id)
        {
            var query = new GetBookTagByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            var response = _mapper.Map<BookTagResponseModel>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<BookTagResponseModel>> Create([FromBody] CreateBookTagRequestModel requestModel)
        {
            var command = _mapper.Map<CreateBookTagCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<BookTagResponseModel>(result);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<BookTagResponseModel>> Update([FromBody] UpdateBookTagRequestModel requestModel)
        {
            var command = _mapper.Map<UpdateBookTagCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<BookTagResponseModel>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteBookTagCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}


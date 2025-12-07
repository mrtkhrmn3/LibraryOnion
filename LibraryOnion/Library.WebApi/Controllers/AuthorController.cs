using AutoMapper;
using Library.Application.Commands.Author;
using Library.Application.Queries.Author;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthorController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorResponseModel>>> GetAll()
        {
            var query = new GetAllAuthorsQuery();
            var result = await _mediator.Send(query);
            var response = _mapper.Map<List<AuthorResponseModel>>(result);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorResponseModel>> GetById(int id)
        {
            var query = new GetAuthorByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            var response = _mapper.Map<AuthorResponseModel>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorResponseModel>> Create([FromBody] CreateAuthorRequestModel requestModel)
        {
            var command = _mapper.Map<CreateAuthorCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<AuthorResponseModel>(result);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<AuthorResponseModel>> Update([FromBody] UpdateAuthorRequestModel requestModel)
        {
            var command = _mapper.Map<UpdateAuthorCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<AuthorResponseModel>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteAuthorCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

using AutoMapper;
using Library.Application.Commands.Tag;
using Library.Application.Queries.Tag;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TagController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TagResponseModel>>> GetAll()
        {
            var query = new GetAllTagsQuery();
            var result = await _mediator.Send(query);
            var response = _mapper.Map<List<TagResponseModel>>(result);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagResponseModel>> GetById(int id)
        {
            var query = new GetTagByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            var response = _mapper.Map<TagResponseModel>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<TagResponseModel>> Create([FromBody] CreateTagRequestModel requestModel)
        {
            var command = _mapper.Map<CreateTagCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<TagResponseModel>(result);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<TagResponseModel>> Update([FromBody] UpdateTagRequestModel requestModel)
        {
            var command = _mapper.Map<UpdateTagCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<TagResponseModel>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteTagCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}


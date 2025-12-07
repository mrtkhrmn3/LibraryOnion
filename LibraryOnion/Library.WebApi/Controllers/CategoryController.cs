using AutoMapper;
using Library.Application.Commands.Category;
using Library.Application.Queries.Category;
using Library.WebApi.RequestModels;
using Library.WebApi.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoryController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryResponseModel>>> GetAll()
        {
            var query = new GetAllCategoriesQuery();
            var result = await _mediator.Send(query);
            var response = _mapper.Map<List<CategoryResponseModel>>(result);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryResponseModel>> GetById(int id)
        {
            var query = new GetCategoryByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            var response = _mapper.Map<CategoryResponseModel>(result);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryResponseModel>> Create([FromBody] CreateCategoryRequestModel requestModel)
        {
            var command = _mapper.Map<CreateCategoryCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<CategoryResponseModel>(result);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<CategoryResponseModel>> Update([FromBody] UpdateCategoryRequestModel requestModel)
        {
            var command = _mapper.Map<UpdateCategoryCommand>(requestModel);
            var result = await _mediator.Send(command);
            var response = _mapper.Map<CategoryResponseModel>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}


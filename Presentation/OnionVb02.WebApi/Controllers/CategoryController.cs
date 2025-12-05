using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.CategoryQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var result = await _mediator.Send(new GetCategoryQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var result = await _mediator.Send(new GetCategoryByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await _mediator.Send(new DeleteCategoryCommand { Id = id });
            if (result.Success)
                return Ok(new { message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}

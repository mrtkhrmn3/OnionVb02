using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var result = await _mediator.Send(new GetProductQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await _mediator.Send(new GetProductByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _mediator.Send(new DeleteProductCommand { Id = id });
            if (result.Success)
                return Ok(new { message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}


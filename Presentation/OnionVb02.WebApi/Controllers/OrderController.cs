using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderList()
        {
            var result = await _mediator.Send(new GetOrderQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var result = await _mediator.Send(new GetOrderByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var result = await _mediator.Send(new DeleteOrderCommand { Id = id });
            if (result.Success)
                return Ok(new { message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}


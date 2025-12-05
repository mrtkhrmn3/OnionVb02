using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderDetailQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var result = await _mediator.Send(new GetOrderDetailQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetail(int id)
        {
            var result = await _mediator.Send(new GetOrderDetailByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            var result = await _mediator.Send(new DeleteOrderDetailCommand { Id = id });
            if (result.Success)
                return Ok(new { message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}


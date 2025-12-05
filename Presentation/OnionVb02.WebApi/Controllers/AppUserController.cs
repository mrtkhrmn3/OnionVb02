using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AppUserList()
        {
            var result = await _mediator.Send(new GetAppUserQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUser(int id)
        {
            var result = await _mediator.Send(new GetAppUserByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser(CreateAppUserCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppUser(UpdateAppUserCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.Success)
                return Ok(new { message = result.Message, data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            var result = await _mediator.Send(new RemoveAppUserCommand(id));
            if (result.Success)
                return Ok(new { message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}

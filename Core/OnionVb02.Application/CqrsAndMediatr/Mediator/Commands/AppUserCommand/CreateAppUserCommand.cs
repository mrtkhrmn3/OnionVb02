using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults.CommandResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand
{
    public class CreateAppUserCommand : ICommand<CommandResult<CreateAppUserCommandResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

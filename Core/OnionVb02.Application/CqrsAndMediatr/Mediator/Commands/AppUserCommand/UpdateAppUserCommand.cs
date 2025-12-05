using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults.CommandResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand
{
    public class UpdateAppUserCommand : ICommand<CommandResult<UpdateAppUserCommandResult>>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand
{
    public class CreateAppUserProfileCommand : ICommand<CommandResult<CreateAppUserProfileCommandResult>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}


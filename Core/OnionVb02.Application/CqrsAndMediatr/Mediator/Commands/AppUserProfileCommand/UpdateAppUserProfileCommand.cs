using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand
{
    public class UpdateAppUserProfileCommand : ICommand<CommandResult<UpdateAppUserProfileCommandResult>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}


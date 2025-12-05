using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand
{
    public class DeleteAppUserProfileCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }
    }
}


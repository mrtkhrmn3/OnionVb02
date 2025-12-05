using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand
{
    public class RemoveAppUserCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }

        public RemoveAppUserCommand(int id)
        {
            Id = id;
        }
    }
}

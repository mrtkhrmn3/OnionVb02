using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand
{
    public class DeleteOrderCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }
    }
}


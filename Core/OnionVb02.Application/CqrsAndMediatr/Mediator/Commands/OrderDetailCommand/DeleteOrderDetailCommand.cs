using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand
{
    public class DeleteOrderDetailCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }
    }
}


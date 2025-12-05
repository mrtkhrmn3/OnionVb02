using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand
{
    public class CreateOrderDetailCommand : ICommand<CommandResult<CreateOrderDetailCommandResult>>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}


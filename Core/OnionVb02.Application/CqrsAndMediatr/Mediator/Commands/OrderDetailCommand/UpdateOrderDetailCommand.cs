using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand
{
    public class UpdateOrderDetailCommand : ICommand<CommandResult<UpdateOrderDetailCommandResult>>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}


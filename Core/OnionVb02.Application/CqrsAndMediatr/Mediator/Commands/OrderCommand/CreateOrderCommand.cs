using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand
{
    public class CreateOrderCommand : ICommand<CommandResult<CreateOrderCommandResult>>
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}


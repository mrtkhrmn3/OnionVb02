using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand
{
    public class UpdateOrderCommand : ICommand<CommandResult<UpdateOrderCommandResult>>
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}


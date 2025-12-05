using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand
{
    public class CreateProductCommand : ICommand<CommandResult<CreateProductCommandResult>>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
    }
}


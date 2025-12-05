using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand
{
    public class DeleteProductCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }
    }
}


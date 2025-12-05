using OnionVb02.Application.CqrsAndMediatr.Common;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand
{
    public class DeleteCategoryCommand : ICommand<CommandResult>
    {
        public int Id { get; set; }
    }
}


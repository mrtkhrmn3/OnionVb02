using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand
{
    public class CreateCategoryCommand : ICommand<CommandResult<CreateCategoryCommandResult>>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}


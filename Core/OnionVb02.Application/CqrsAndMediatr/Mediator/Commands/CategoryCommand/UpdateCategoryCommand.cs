using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand
{
    public class UpdateCategoryCommand : ICommand<CommandResult<UpdateCategoryCommandResult>>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}


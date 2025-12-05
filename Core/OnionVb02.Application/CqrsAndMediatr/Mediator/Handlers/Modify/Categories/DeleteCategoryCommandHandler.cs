using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Categories
{
    public class DeleteCategoryCommandHandler : BaseDeleteCommandHandler<DeleteCategoryCommand, Category>
    {
        public DeleteCategoryCommandHandler(ICategoryRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(DeleteCategoryCommand request)
        {
            return request.Id;
        }
    }
}


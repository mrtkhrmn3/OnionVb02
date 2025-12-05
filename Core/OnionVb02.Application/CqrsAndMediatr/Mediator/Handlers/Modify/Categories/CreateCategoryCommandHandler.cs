using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Categories
{
    public class CreateCategoryCommandHandler 
        : BaseCreateCommandHandler<CreateCategoryCommand, Category, CreateCategoryCommandResult>
    {
        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}


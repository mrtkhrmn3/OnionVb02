using OnionVb02.Application.CqrsAndMediatr.CQRS.Commands.CategoryCommands;
using OnionVb02.Contract.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.CQRS.Handlers.Modify
{
    public class CreateCategoryCommandHandler
    {
        private readonly ICategoryRepository _repository;

        public CreateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommands command)
        {
            await _repository.CreateAsync(new Domain.Entities.Category
            {
                CategoryName = command.CategoryName,
                Description = command.Description,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            });
        }
    }
}

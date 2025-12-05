using OnionVb02.Application.CqrsAndMediatr.CQRS.Results.CategoryResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.CQRS.Handlers.Read
{
    public class GetCategoryQueryHandler
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryIdQueryResult>> Handle()
        {
            List<Category> values = await _repository.GetAllAsync();

            return values.Select(x => new GetCategoryIdQueryResult
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.Id
            }).ToList();
        }
    }
}

using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.Products
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductQueryResult>>(products);
        }
    }
}


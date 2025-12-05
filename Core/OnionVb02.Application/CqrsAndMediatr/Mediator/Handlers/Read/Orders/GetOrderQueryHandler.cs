using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.Orders
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, List<GetOrderQueryResult>>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetOrderQueryResult>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var orders = await _repository.GetAllAsync();
            return _mapper.Map<List<GetOrderQueryResult>>(orders);
        }
    }
}


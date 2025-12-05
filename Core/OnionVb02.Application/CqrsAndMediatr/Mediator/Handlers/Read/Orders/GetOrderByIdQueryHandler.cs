using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.Orders
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderByIdQueryResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetOrderByIdQueryResult>(order);
        }
    }
}


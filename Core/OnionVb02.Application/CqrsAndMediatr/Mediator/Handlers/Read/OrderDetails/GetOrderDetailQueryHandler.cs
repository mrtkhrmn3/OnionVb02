using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderDetailQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.OrderDetails
{
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, List<GetOrderDetailQueryResult>>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public GetOrderDetailQueryHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {
            var orderDetails = await _repository.GetAllAsync();
            return _mapper.Map<List<GetOrderDetailQueryResult>>(orderDetails);
        }
    }
}


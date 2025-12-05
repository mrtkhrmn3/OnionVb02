using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderDetailQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.OrderDetails
{
    public class GetOrderDetailByIdQueryHandler : IRequestHandler<GetOrderDetailByIdQuery, GetOrderDetailByIdQueryResult>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public GetOrderDetailByIdQueryHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var orderDetail = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetOrderDetailByIdQueryResult>(orderDetail);
        }
    }
}


using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Orders
{
    public class CreateOrderCommandHandler 
        : BaseCreateCommandHandler<CreateOrderCommand, Order, CreateOrderCommandResult>
    {
        public CreateOrderCommandHandler(IOrderRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}


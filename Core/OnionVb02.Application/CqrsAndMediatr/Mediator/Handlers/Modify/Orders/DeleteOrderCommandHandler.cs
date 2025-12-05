using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Orders
{
    public class DeleteOrderCommandHandler : BaseDeleteCommandHandler<DeleteOrderCommand, Order>
    {
        public DeleteOrderCommandHandler(IOrderRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(DeleteOrderCommand request)
        {
            return request.Id;
        }
    }
}


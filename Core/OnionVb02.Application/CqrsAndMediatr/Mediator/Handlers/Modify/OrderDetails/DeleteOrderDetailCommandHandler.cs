using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderDetails
{
    public class DeleteOrderDetailCommandHandler : BaseDeleteCommandHandler<DeleteOrderDetailCommand, OrderDetail>
    {
        public DeleteOrderDetailCommandHandler(IOrderDetailRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(DeleteOrderDetailCommand request)
        {
            return request.Id;
        }
    }
}


using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderDetails
{
    public class UpdateOrderDetailCommandHandler 
        : BaseUpdateCommandHandler<UpdateOrderDetailCommand, OrderDetail, UpdateOrderDetailCommandResult>
    {
        public UpdateOrderDetailCommandHandler(IOrderDetailRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}


using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Products
{
    public class DeleteProductCommandHandler : BaseDeleteCommandHandler<DeleteProductCommand, Product>
    {
        public DeleteProductCommandHandler(IProductRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(DeleteProductCommand request)
        {
            return request.Id;
        }
    }
}


using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.Products
{
    public class UpdateProductCommandHandler 
        : BaseUpdateCommandHandler<UpdateProductCommand, Product, UpdateProductCommandResult>
    {
        public UpdateProductCommandHandler(IProductRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}


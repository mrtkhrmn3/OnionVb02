using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.CategoryCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults.CommandResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.MappingProfiles
{
    public class MediatorMappingProfile : Profile
    {
        public MediatorMappingProfile()
        {
            CreateMap<CreateAppUserCommand, AppUser>();
            CreateMap<UpdateAppUserCommand, AppUser>();
            CreateMap<AppUser, CreateAppUserCommandResult>();
            CreateMap<AppUser, UpdateAppUserCommandResult>();
            CreateMap<AppUser, GetAppUserQueryResult>();
            CreateMap<AppUser, GetAppUserByIdQueryResult>();

            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<Product, CreateProductCommandResult>();
            CreateMap<Product, UpdateProductCommandResult>();
            CreateMap<Product, GetProductQueryResult>();
            CreateMap<Product, GetProductByIdQueryResult>();

            CreateMap<CreateAppUserProfileCommand, AppUserProfile>();
            CreateMap<UpdateAppUserProfileCommand, AppUserProfile>();
            CreateMap<AppUserProfile, CreateAppUserProfileCommandResult>();
            CreateMap<AppUserProfile, UpdateAppUserProfileCommandResult>();
            CreateMap<AppUserProfile, GetAppUserProfileQueryResult>();
            CreateMap<AppUserProfile, GetAppUserProfileByIdQueryResult>();

            CreateMap<CreateOrderCommand, Order>();
            CreateMap<UpdateOrderCommand, Order>();
            CreateMap<Order, CreateOrderCommandResult>();
            CreateMap<Order, UpdateOrderCommandResult>();
            CreateMap<Order, GetOrderQueryResult>();
            CreateMap<Order, GetOrderByIdQueryResult>();

            CreateMap<CreateOrderDetailCommand, OrderDetail>();
            CreateMap<UpdateOrderDetailCommand, OrderDetail>();
            CreateMap<OrderDetail, CreateOrderDetailCommandResult>();
            CreateMap<OrderDetail, UpdateOrderDetailCommandResult>();
            CreateMap<OrderDetail, GetOrderDetailQueryResult>();
            CreateMap<OrderDetail, GetOrderDetailByIdQueryResult>();

            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, CreateCategoryCommandResult>();
            CreateMap<Category, UpdateCategoryCommandResult>();
            CreateMap<Category, GetCategoryQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();
        }
    }
}


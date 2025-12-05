using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.CQRS.Commands.CategoryCommands;
using OnionVb02.Application.CqrsAndMediatr.CQRS.Results.CategoryResults;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.MappingProfiles
{
    public class CQRSMappingProfile : Profile
    {
        public CQRSMappingProfile()
        {
            CreateMap<CreateCategoryCommands, Category>();
            CreateMap<UpdateCategoryCommands, Category>();
            CreateMap<Category, GetCategoryIdQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();
        }
    }
}


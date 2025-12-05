using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults.CommandResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class CreateAppUserCommandHandler 
        : BaseCreateCommandHandler<CreateAppUserCommand, AppUser, CreateAppUserCommandResult>
    {
        public CreateAppUserCommandHandler(IAppUserRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}

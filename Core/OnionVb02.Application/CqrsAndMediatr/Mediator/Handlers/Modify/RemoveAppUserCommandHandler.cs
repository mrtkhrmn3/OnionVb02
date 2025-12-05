using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class RemoveAppUserCommandHandler : BaseDeleteCommandHandler<RemoveAppUserCommand, AppUser>
    {
        public RemoveAppUserCommandHandler(IAppUserRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(RemoveAppUserCommand request)
        {
            return request.Id;
        }
    }
}

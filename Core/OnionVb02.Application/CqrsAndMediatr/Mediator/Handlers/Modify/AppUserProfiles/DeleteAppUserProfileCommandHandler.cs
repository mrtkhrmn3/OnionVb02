using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserProfiles
{
    public class DeleteAppUserProfileCommandHandler : BaseDeleteCommandHandler<DeleteAppUserProfileCommand, AppUserProfile>
    {
        public DeleteAppUserProfileCommandHandler(IAppUserProfileRepository repository) 
            : base(repository)
        {
        }

        protected override int GetEntityId(DeleteAppUserProfileCommand request)
        {
            return request.Id;
        }
    }
}


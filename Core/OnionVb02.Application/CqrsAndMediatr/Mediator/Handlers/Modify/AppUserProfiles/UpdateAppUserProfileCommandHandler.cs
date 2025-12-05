using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Common;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommand;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserProfiles
{
    public class UpdateAppUserProfileCommandHandler 
        : BaseUpdateCommandHandler<UpdateAppUserProfileCommand, AppUserProfile, UpdateAppUserProfileCommandResult>
    {
        public UpdateAppUserProfileCommandHandler(IAppUserProfileRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}


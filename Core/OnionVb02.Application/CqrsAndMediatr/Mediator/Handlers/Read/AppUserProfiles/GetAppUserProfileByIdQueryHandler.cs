using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserProfileQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.AppUserProfiles
{
    public class GetAppUserProfileByIdQueryHandler : IRequestHandler<GetAppUserProfileByIdQuery, GetAppUserProfileByIdQueryResult>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserProfileByIdQueryHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserProfileByIdQueryResult> Handle(GetAppUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var profile = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetAppUserProfileByIdQueryResult>(profile);
        }
    }
}


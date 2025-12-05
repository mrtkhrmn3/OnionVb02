using AutoMapper;
using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserProfileQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.AppUserProfiles
{
    public class GetAppUserProfileQueryHandler : IRequestHandler<GetAppUserProfileQuery, List<GetAppUserProfileQueryResult>>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserProfileQueryHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAppUserProfileQueryResult>> Handle(GetAppUserProfileQuery request, CancellationToken cancellationToken)
        {
            var profiles = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAppUserProfileQueryResult>>(profiles);
        }
    }
}


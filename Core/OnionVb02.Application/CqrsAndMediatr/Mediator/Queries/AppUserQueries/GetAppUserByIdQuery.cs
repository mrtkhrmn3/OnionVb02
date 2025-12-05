using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserQueries
{
    public class GetAppUserByIdQuery : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAppUserByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}

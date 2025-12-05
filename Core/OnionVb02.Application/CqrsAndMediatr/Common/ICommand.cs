using MediatR;

namespace OnionVb02.Application.CqrsAndMediatr.Common
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }

    public interface ICommand : IRequest
    {
    }
}


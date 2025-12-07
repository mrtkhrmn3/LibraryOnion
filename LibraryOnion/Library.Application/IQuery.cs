using MediatR;

namespace Library.Application
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}


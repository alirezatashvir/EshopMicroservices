using MediatR;

namespace BuildingBlocks.CQR
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}

using MediatR;

namespace BuildingBlocks.CQR
{
    internal interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}

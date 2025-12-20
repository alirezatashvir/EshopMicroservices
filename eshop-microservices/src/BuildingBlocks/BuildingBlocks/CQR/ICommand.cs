using MediatR;

namespace BuildingBlocks.CQR
{
    public interface ICommand : IRequest<Unit>
    {
    }
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}

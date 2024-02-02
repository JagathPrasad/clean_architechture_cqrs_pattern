using Domain.Shared;

namespace Application.Abstraction
{
    public interface IQueryHandler<in TQuery,TResponse> where TQuery : IQuery<TResponse>
    {
        Task<Result<TResponse>> Handle(TQuery query, CancellationToken token);
    }
}

using Domain.Shared;
using MediatR;
namespace Application.Abstraction
{
    public interface ICommandHandler<T> : IRequestHandler<T, Result> where T : ICommand
    {
    }

    public interface ICommandHandler<T, TRequest> : IRequestHandler<T, Result<TRequest>> where T : ICommand<TRequest> { 
    
    }
}

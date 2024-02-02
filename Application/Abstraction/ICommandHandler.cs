using Domain.Shared;
using MediatR;
namespace Application.Abstraction
{
    //public interface ICommandHandler<T> : IRequestHandler<T, Result> where T : ICommand
    //{
    //}

    //public interface ICommandHandler<T, TRequest> : IRequestHandler<T, Result<TRequest>> where T : ICommand<TRequest> { 

    //}


    public interface ICommand1Handler<in TCommand> where TCommand : ICommand1
    {
        Task<Result> Handle(TCommand command, CancellationToken token);
    }

    public interface ICommand1Handler<in TCommand, TResponse> where TCommand : ICommand1<TResponse>
    {
        Task<Result<TResponse>> Handle(TCommand command, CancellationToken token);
    }
}

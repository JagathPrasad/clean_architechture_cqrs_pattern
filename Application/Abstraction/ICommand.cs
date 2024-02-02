using Domain.Shared;
using MediatR;
namespace Application.Abstraction
{
    //public interface ICommand : IRequest<Result>
    //{
    //}

    //public interface ICommand<T> : IRequest<Result<T>>
    //{

    //}



    //doesnt return the value
    public interface ICommand1 : IBaseCommand1
    {

    }
    //returns the value
    public interface ICommand1<TResponse> : IBaseCommand1
    {

    }

    public interface IBaseCommand1
    {

    }
}

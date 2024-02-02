using Application.Abstraction;
using MediatR;

namespace Application.User.Command
{
    //public record class CreateUserCommand(string Email,string Password):IRequest;
    public record class CreateUserCommand(string Email, string Password) : ICommand1;

}

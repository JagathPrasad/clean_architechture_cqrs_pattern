using MediatR;

namespace Application.User.Command
{
    public record class CreateUserCommand(string Email,string Password):IRequest;
    
}

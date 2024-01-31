using Domain.Abstraction;
using Domain.Entities;
using MediatR;

namespace Application.User.Command
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        IUserRepository _repository;
        IUoWRepository _uoWRepository;
        public CreateUserCommandHandler(
            IUserRepository repository, IUoWRepository uoWRepository)
        {
            _repository = repository;
            _uoWRepository = uoWRepository;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellation)
        {
            var user = new Users(Guid.NewGuid(), request.Email, request.Password);
            await _repository.AddUserAsync(user);
            await _uoWRepository.SaveAsync(cancellation);
            return true;
        }

        //public async Task IRequestHandler<CreateUserCommand>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
        //{
        //    var user = new Users(Guid.NewGuid(), request.Email, request.Password);
        //    await _repository.AddUserAsync(user);
        //    await _uoWRepository.SaveAsync(cancellationToken);
        //    return new CreateUserCommand("", "");
        //}
    }
}

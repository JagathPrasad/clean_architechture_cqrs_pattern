using Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.User.Command
{
    public class CreateUserCommandHandler
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
            var user = new Users(Guid.NewGuid(), "name", "email");
            await _repository.AddUserAsync(user);
            await _uoWRepository.SaveAsync(cancellation);
            return true;
        }
    }
}

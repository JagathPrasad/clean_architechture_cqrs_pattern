using Domain.Abstraction;
using Domain.Entities;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> AddUserAsync(Users user, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<Result> GetUserByEmail(string email, CancellationToken token)
        {
            throw new NotImplementedException();

        }
    }
}

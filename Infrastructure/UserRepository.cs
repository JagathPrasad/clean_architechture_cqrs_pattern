using Domain.Abstraction;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> AddUserAsync(Users user)
        {
            throw new NotImplementedException();
        }
    }
}

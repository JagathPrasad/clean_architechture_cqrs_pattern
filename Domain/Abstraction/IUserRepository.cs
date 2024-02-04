using Domain.Entities;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IUserRepository
    {
        Task<bool> AddUserAsync(Users user, CancellationToken token = default);
        Task<Result> GetUserByEmail(string email, CancellationToken token = default);
    }
}

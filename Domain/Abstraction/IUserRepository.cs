using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IUserRepository
    {
        Task<bool> AddUserAsync(Users user);
    }
}

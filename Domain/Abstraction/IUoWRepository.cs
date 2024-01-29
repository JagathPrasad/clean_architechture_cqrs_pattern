using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IUoWRepository
    {
        Task<bool> SaveAsync(CancellationToken cancellation = default);
    }
}

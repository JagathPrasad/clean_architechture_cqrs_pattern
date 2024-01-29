using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid userId):base($"User Not found issue {userId.ToString()}") { 
        
        }
    }
}

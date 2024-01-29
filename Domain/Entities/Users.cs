using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Users : BaseEntity
    {
        public Users()
        {

        }
        public Users(Guid id, string name, string email) : base(id)
        {
            Name = name;
            Email = email;
        }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

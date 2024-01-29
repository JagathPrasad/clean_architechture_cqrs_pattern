using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }
        public BaseEntity(Guid _id) => id = _id;
        Guid id { get; set; }
    }
}

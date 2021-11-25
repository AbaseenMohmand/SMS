using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}

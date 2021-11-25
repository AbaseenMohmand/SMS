using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }

    }
}

using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.EmployeeTypes
{
   public interface IEmployeeTypesRep
    {
        List<EmployeeTypeViewModel> GetAllEmployeeType();
    }
}

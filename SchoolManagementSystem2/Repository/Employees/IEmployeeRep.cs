using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Employees
{
   public interface IEmployeeRep
    {
        List<EmployeeViewModel> GetAllEmployee();
        List<EmployeeTypeViewModel> GetAllEmployeeByType(int typeId);
        void DeleteEmployee(int? id);
        EmployeeViewModel GetEmployee(int id);
        EmployeeViewModel AddOrEditEmployee(EmployeeViewModel employeeViewModel);
    }
}

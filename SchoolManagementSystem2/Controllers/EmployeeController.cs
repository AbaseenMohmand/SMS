using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Employees;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRep _interfaceEmployee;


        public EmployeeController(IEmployeeRep interfaceEmployee)
        {
            _interfaceEmployee = interfaceEmployee;

        }
        public IActionResult Index()
        {
            var Getall = _interfaceEmployee.GetAllEmployee();



            return View(Getall);
        }

        public IActionResult AddOrEditEmployee(int id = 0)
        {

            var vm = new EmployeeViewModel();
            if (id == 0)
            {
                return View(new EmployeeViewModel());
            }
            else
            {
                var data = _interfaceEmployee.GetEmployee(id);
                vm.FirstName = data.FirstName;
                vm.LastName = data.LastName;
                vm.Email = data.Email;
                vm.Dob = data.Dob;
                vm.Designation = data.Designation;
                vm.ContactNo = data.ContactNo;  
                vm.Id = data.Id;
                data.CreatedOn = DateTime.Now;

                vm.CreatedBy = data.CreatedBy;
                vm.CreatedIP = data.CreatedIP;
            }

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditEmployee(EmployeeViewModel EmployeeVM)
        {
            _interfaceEmployee.AddOrEditEmployee(EmployeeVM);

            return RedirectToAction(nameof(Index));

        }

            public IActionResult DeleteEmployee(int? id)
        {
            _interfaceEmployee.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class EmployeeTypeController : Controller
    {
        private readonly IEmployeeTypesRep _interfaceEmployeeTypes;

        public EmployeeTypeController(IEmployeeTypesRep interfaceEmployeeTypes)
        {
            _interfaceEmployeeTypes = interfaceEmployeeTypes;


        }
        public IActionResult Index()
        {
            var Getall = _interfaceEmployeeTypes.GetAllEmployeeType();



            return View(Getall);
        }
    }
}

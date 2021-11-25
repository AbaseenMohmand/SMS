using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Employees;
using SchoolManagementSystem2.Repository.EmployeeTypes;
using SchoolManagementSystem2.Repository.Months;
using SchoolManagementSystem2.Repository.Salleries;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class SalleryController : Controller
    {
        private readonly ISalleryRep _interfaceSallery;
        private readonly IEmployeeRep _interfaceEmployee;
        private readonly IEmployeeTypesRep _interfaceEmployeeTypes;
        private readonly IMonthRep _interfaceMonths;

        public SalleryController(ISalleryRep interfaceSallery, 
                                 IEmployeeRep interfaceEmployee, 
                                 IEmployeeTypesRep interfaceEmployeeTypes, 
                                 IMonthRep interfaceMonths)
        {
            _interfaceSallery = interfaceSallery;
            _interfaceEmployee = interfaceEmployee;
            _interfaceEmployeeTypes = interfaceEmployeeTypes;
            _interfaceMonths = interfaceMonths;

        }
        public IActionResult Index()
        {
            var Getall = _interfaceSallery.GetAllSallery();



            return View(Getall);
        }

        public IActionResult AddOrEditSallery(int id = 0)
        {

            var vm = new SalleryViewModel();
            if (id == 0)
            {
                return View(new SalleryViewModel());
            }
            else
            {
                var data = _interfaceSallery.GetSallery(id);
                
                
                vm.Id = data.Id;
                vm.EmployeeType = data.EmployeeType;
                vm.EmployeeId = data.EmployeeId;
                vm.MonthId = data.MonthId;

            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditSallery(SalleryViewModel salleryViewModel)
        {
            _interfaceSallery.AddOrEditSallery(salleryViewModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteSallery(int? id)
        {
            _interfaceSallery.DeleteSallery(id);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var data = _interfaceEmployee.GetAllEmployee();
            return Json(data);
        }
        [HttpGet]
        public IActionResult GetEmployeeByType(int type)
        {
            var data = _interfaceEmployee.GetAllEmployeeByType(type);
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetEmployeeType()
        {
            var data = _interfaceEmployeeTypes.GetAllEmployeeType();
            return Json(data);
        }


        [HttpGet]
        public IActionResult GetMonth()
        {
            var data = _interfaceMonths.GetAllMonth();
            return Json(data);
        }
    }
}

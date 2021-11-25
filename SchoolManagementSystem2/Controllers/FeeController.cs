using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Class;
using SchoolManagementSystem2.Repository.Fees;
using SchoolManagementSystem2.Repository.Months;
using SchoolManagementSystem2.Repository.Students;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class FeeController : Controller
    {
        private readonly IFeesRep _interfaceFees;
        private readonly IClassRep _interfaceClass;
        private readonly IStudentRep _interfaceStudent;
        private readonly IMonthRep _interfaceMonth;


        public FeeController(IFeesRep interfaceFees,
                             IMonthRep interfaceMonth,
                             IClassRep interfaceClass, 
                             IStudentRep interfaceStudent)
        {
            _interfaceFees = interfaceFees;

            _interfaceStudent = interfaceStudent;

            _interfaceClass = interfaceClass;
            _interfaceMonth = interfaceMonth;
        }
        public IActionResult Index()
        {
            var Getall = _interfaceFees.GetAllFee();



            return View(Getall);
        }

        public IActionResult AddOrEditFee(int id = 0)
        {

            var vm = new FeeViewModel();
            if (id == 0)
            {
                return View(new FeeViewModel());
            }
            else
            {
                var data = _interfaceFees.GetFee(id);
                vm.Amount = data.Amount;
                vm.StudentId = data.Id;
                vm.Id = data.Id;
                vm.ClassId = data.Id;
                vm.MonthId = data.MonthId;

            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditFee(FeeViewModel feeViewModel)
        {
            _interfaceFees.AddOrEditFee(feeViewModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteFee(int? id)
        {
            _interfaceFees.DeleteFee(id);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult GetClasses()
        {
            var data = _interfaceClass.GetAllClass();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetStudents(int id)
        {
            var data = _interfaceStudent.GetAllStudentByClass(id);
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetMonth()
        {
            var data = _interfaceMonth.GetAllMonth();
            return Json(data);
        }
    }
}

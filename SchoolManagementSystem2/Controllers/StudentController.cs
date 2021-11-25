using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Class;
using SchoolManagementSystem2.Repository.Students;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class StudentController : Controller
    {
       
        private readonly IStudentRep _iStudentRep;
        private readonly IClassRep _interfaceClass;
        
        public StudentController(IStudentRep iStudentRep,  IClassRep interfaceClass)
        {

            _iStudentRep = iStudentRep;
            _interfaceClass = interfaceClass;
           

        }
        public IActionResult Index()
        {
            var Getall = _iStudentRep.GetAllStudent();



            return View(Getall);
        }

        public IActionResult Insert()
        {
            //var Vm = new StudentAndGuardViewModel();
            //var studentData = _interfaceRegistration.GetStudentAndGuardian(id);
            //var guardianData = _interfaceRegistration.GetStudentAndGuardian(id);
            //if (id  == null)
            //{
            //    return View(new StudentAndGuardViewModel());
            //}
            //else
            //{
            //    Vm.FirstName = studentData.FirstName;
            //    Vm.LastName = studentData.LastName;
            //    Vm.Email = studentData.Email;
            //    Vm.CNIC = studentData.CNIC;
            //    Vm.MobileNO = studentData.MobileNO;
            //    Vm.Gender = studentData.Gender;
            //    Vm.Dob = studentData.Dob;
            //    Vm.ClassId = studentData.Id;

            //    Vm.Address = studentData.Address;
            //    Vm.City = studentData.City;
            //    Vm.Country = studentData.Country;
            //    Vm.GFirstName = guardianData.GFirstName;
            //    Vm.GLastName = guardianData.GLastName;
            //    Vm.GCNIC = guardianData.GCNIC;
            //    Vm.GMobileNo = guardianData.GMobileNo;
            //    Vm.GAddress = guardianData.GAddress;
            //    Vm.GuardianType = guardianData.GuardianType;

            //}

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(StudentAndGuardViewModel studentAndGuardViewModel)
        {
            _iStudentRep.Insert(studentAndGuardViewModel);

            return RedirectToAction("index", "student");

        }

        public IActionResult DeleteStudent(int? id)
        {
            _iStudentRep.DeleteStudent(id);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult GetClasses()
        {
            var data = _interfaceClass.GetAllClass();
            return Json(data);
        }
    }
}

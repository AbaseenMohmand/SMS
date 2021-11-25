using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Attendances;
using SchoolManagementSystem2.Repository.Sections;
using SchoolManagementSystem2.Repository.Students;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendanceRep _interfaceAttendance;
        private readonly ISectionRep _interfaceSection;
        private readonly IStudentRep _interfaceStudent;

        public AttendanceController(IAttendanceRep interfaceAttendance,
                                    ISectionRep interfaceSection,
                                     IStudentRep interfaceStudent)
        {
            _interfaceAttendance = interfaceAttendance;
            _interfaceStudent = interfaceStudent;
            _interfaceSection = interfaceSection;


        }
        public IActionResult Index()
        {
            var Getall = _interfaceAttendance.GetAllAttendance();



            return View(Getall);
        }

        public IActionResult AddOrEditAttendance(int id = 0)
        {

            var vm = new AttendanceViewModel();
            if (id == 0)
            {
                return View(new AttendanceViewModel());
            }
            else
            {
                var data = _interfaceAttendance.GetAttendance(id);
                vm.AttendaceId = data.AttendaceId;
                vm.StudentId = data.Id;
                vm.Id = data.Id;
                vm.ClassId = data.Id;
                vm.SectionId = data.SectionId;
                vm.AttendanceType = data.AttendanceType;
                vm.Date = DateTime.Now;

            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditAttendance(AttendanceViewModel AttendanceViewModel)
        {
            _interfaceAttendance.AddOrEditAttendance(AttendanceViewModel);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteAttendance(int? id)
        {
            _interfaceAttendance.DeleteAttendance(id);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult GetSection(int id)
        {
            var data = _interfaceStudent.GetAllStudentByClass(id);
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetSectionById(int id)
        {
            var data = _interfaceAttendance.GetAllSectionsByClass(id);
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetSections()
        {
            var data = _interfaceSection.GetAllSection();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetStudentsByClassAndSection(int ClassId, int SectionId)
        {
            var data = _interfaceAttendance.GetStudentForAttendance(ClassId, SectionId);
            return Json(data);
        }

        //[HttpGet]
        //public IActionResult GetStudents(int clsasId,sectionId)
        //{
        //    var data = _interfaceRegistration.GetAllSection();
        //    return Json(data);
        //}
    }
}

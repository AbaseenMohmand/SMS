using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Teachers;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRep _interfacTeacher;
       
        public TeacherController(ITeacherRep interfacTeacher)
        {
            _interfacTeacher = interfacTeacher;
         
        }
        public IActionResult Index()
        {
            var Getall = _interfacTeacher.GetAllTeacher();



            return View(Getall);
        }

        public IActionResult AddOrEditTeacher(int id = 0)
        {

            var vm = new TeacherViewModel();
            if (id == 0)
            {
                return View(new TeacherViewModel());
            }
            else
            {
                var data = _interfacTeacher.GetTeacher(id);
                vm.FirstName = data.FirstName;
                vm.LastName = data.LastName;
                vm.Email = data.Email;
               
                vm.Id = data.Id;
                data.CreatedOn = DateTime.Now;

                vm.CreatedBy = data.CreatedBy;
                vm.CreatedIP = data.CreatedIP;
            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditTeacher(TeacherViewModel teacherVM)
        {
            _interfacTeacher.AddOrEditTeacher(teacherVM);
          
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteTeacher(int? id)
        {
            _interfacTeacher.DeleteTeacher(id);
            return RedirectToAction(nameof(Index));

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Class;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassRep _interfaceClass;
       
        public ClassController(IClassRep interfaceClass)
        {
            _interfaceClass = interfaceClass;
          

        }
        public IActionResult Index()
        {
            var Getall = _interfaceClass.GetAllClass();



            return View(Getall);
        }

        public IActionResult AddOrEditClass(int id = 0)
        {

            var vm = new ClassViewModel();
            if (id == 0)
            {
                return View(new ClassViewModel());
            }
            else
            {
                var data = _interfaceClass.GetClass(id);
                vm.Name = data.Name;
                vm.CreatedBy = data.CreatedBy;
                vm.Id = data.Id;
                data.CreatedOn = DateTime.Now;
                data.UpdatedOn = DateTime.Now;
                // test
                // test
                
            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditClass(ClassViewModel classVM)
        {
            _interfaceClass.AddOrEditClass(classVM);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteClass(int? id)
        {
            _interfaceClass.DeleteClass(id);
            return RedirectToAction(nameof(Index));

        }
    }
}

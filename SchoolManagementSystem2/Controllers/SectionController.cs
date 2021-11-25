using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Class;
using SchoolManagementSystem2.Repository.Sections;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class SectionController : Controller
    {
        private readonly ISectionRep _interfaceSection;
        private readonly IClassRep _interfaceClass;

        public SectionController(ISectionRep interfaceSection, IClassRep interfaceClass)
        {
            _interfaceSection = interfaceSection;
            _interfaceClass = interfaceClass;

        }
        public IActionResult Index()
        {
            var Getall = _interfaceSection.GetAllSection();



            return View(Getall);
        }

        public IActionResult AddOrEditSection(int id = 0)
        {

            var vm = new SectionViewModel();
            if (id == 0)
            {
                return View(new SectionViewModel());
            }
            else
            {
                var data = _interfaceSection.GetSection(id);
                vm.Name = data.Name;
                vm.CreatedBy = data.CreatedBy;
                vm.Id = data.Id;
                vm.ClassId = data.Id;
                data.CreatedOn = DateTime.Now;
                data.UpdatedOn = DateTime.Now;

            }

            return View(vm);
        }


        // POST: StudentRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditSection(SectionViewModel sectionVM)
        {
            _interfaceSection.AddOrEditSection(sectionVM);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteSection(int? id)
        {
            _interfaceSection.DeleteSection(id);
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

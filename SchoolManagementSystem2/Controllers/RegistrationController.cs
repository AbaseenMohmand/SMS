using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Registrations;
using SchoolManagementSystem2.ViewModels;

namespace SchoolManagementSystem2.Controllers
{
    public class RegistrationController : Controller
    {
        
        private readonly IRegistrationRep _interfaceRegistration;

        

        public RegistrationController(IRegistrationRep interfaceRegistration)
        {
            _interfaceRegistration = interfaceRegistration;
        }

        // GET: StudentRegs
        public IActionResult Index()
        {
            var Getall = _interfaceRegistration.GetAll();
          

            
            return  View(Getall);
        }

        public IActionResult GetByName(int id)
        {

            var Getstudent = _interfaceRegistration.GetByName(id);

            return View(Getstudent);
        }



        //        // GET: StudentRegs/Create
        public IActionResult AddOrEdit(int id = 0)
        {

           var vm = new StudentViewModel();
            if (id == 0)
            {
                return View(new StudentViewModel());
            }
            else
            {
                var data = _interfaceRegistration.GetByName(id);
                vm.SchoolName = data.SchoolName;
                vm.Email = data.Email;
                vm.Password = data.Password;
                vm.ConfirmPassword = data.ConfirmPassword;
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
        public IActionResult AddOrEdit(StudentViewModel studentVM)
        {
            _interfaceRegistration.AddOrEdit(studentVM);
            // var studnet = new  Students();
            //var studentReg = new StudentReg();
            //studentReg.SchoolName = studentVM.SchoolName;
            //studentReg.Email = studentVM.Email;
            //studentReg.Password = studentVM.Password;
            //studentReg.ConfirmPassword = studentVM.ConfirmPassword;
            //studentReg.Id = studentVM.Id;
            //studentReg.CreatedOn = DateTime.Now;
            //studentReg.CreatedBy = 1;
            //studentReg.CreatedIP = "67676";

            //// studnet.name= studentReg.name
            //if (ModelState.IsValid)
            //{
            //    if (studentReg.Id == 0)
            //        _context.Add(studentReg);
            //    else
            //        _context.Update(studentReg);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            return RedirectToAction(nameof(Index));
        }





        // GET: StudentRegs/Delete/5
        public IActionResult Delete(int? id)
        {
            _interfaceRegistration.Delete(id);
            return RedirectToAction(nameof(Index));

        }


    }
}

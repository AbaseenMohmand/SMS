using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Registrations
{
    public class RegistrationRep : IRegistrationRep
    {
        private readonly StudentDbContext _context;

        public RegistrationRep(StudentDbContext context)
        {
            _context = context;

        }
        public List<StudentViewModel> GetAll()
        {
            var listData = new List<StudentViewModel>();
            var list = _context.Registration.ToList();
            foreach (var item in list)
            {
                listData.Add(new StudentViewModel()
                {
                    SchoolName = item.SchoolName,
                    Email = item.Email,
                    Password = item.Password,
                    ConfirmPassword = item.ConfirmPassword,
                    Id = item.Id,
                    CreatedOn = item.CreatedOn,
                    CreatedBy = item.CreatedBy,
                    CreatedIP = item.CreatedIP
                });



            }

            return listData;
        }
        public StudentViewModel AddOrEdit(StudentViewModel studentVM)
        {

            var studentReg = new StudentReg();
            studentReg.SchoolName = studentVM.SchoolName;
            studentReg.Email = studentVM.Email;
            studentReg.Password = studentVM.Password;
            studentReg.ConfirmPassword = studentVM.ConfirmPassword;
            studentReg.Id = studentVM.Id;
            studentReg.CreatedOn = DateTime.Now;
            studentReg.CreatedBy = 1;
            studentReg.CreatedIP = "67676";



            if (studentVM.Id > 0)
            {

                _context.Registration.Update(studentReg);
            }
            else
            {
                // var result= _context.Students.Add(studentReg);
                _context.Registration.Add(studentReg);
                // G.firstNAme= vm.GfirstNAme;
                //G.StudentId = result.Id
                // var result= _context.Guardians.Add(guard);
                //


            }

            _context.SaveChanges();


            return studentVM;
        }
        public StudentViewModel GetByName(int id)
        {
            var StudentVM = new StudentViewModel();
            var data = _context.Registration.SingleOrDefault(c => c.Id == id);

            StudentVM.SchoolName = data.SchoolName;
            StudentVM.Email = data.Email;
            StudentVM.Password = data.Password;
            StudentVM.ConfirmPassword = data.ConfirmPassword;
            StudentVM.Id = data.Id;
            StudentVM.CreatedOn = data.CreatedOn;
            StudentVM.CreatedBy = data.CreatedBy;
            StudentVM.CreatedIP = data.CreatedIP;

            return StudentVM;
        }
     
        public void Delete(int? id)
        {
            var student = _context.Registration.Find(id);
            _context.Registration.Remove(student);
            _context.SaveChanges();


        }
    }
}

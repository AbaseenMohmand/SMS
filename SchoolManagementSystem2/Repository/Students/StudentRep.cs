using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Students
{
    public class StudentRep : IStudentRep
    {
        private readonly StudentDbContext _context;


        public StudentRep(StudentDbContext context)
        {
            _context = context;

        }
        public void DeleteStudent(int? id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<StudentAndGuardViewModel> GetAllStudent()
        {
            var listData = new List<StudentAndGuardViewModel>();
            var list = _context.Students.ToList();
            foreach (var item in list)
            {
                var classes = _context.Classes.FirstOrDefault(x => x.Id == item.ClassId);
                var section = _context.Sections.FirstOrDefault(x => x.Id == item.SectionId);
                listData.Add(new StudentAndGuardViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CNIC = item.CNIC,
                    MobileNO = item.MobileNO,
                    Gender = item.Gender,
                    Dob = item.Dob,
                    ClassId = item.ClassId,
                    ClassName = classes.Name,
                    SectionId = item.SectionId,
                    SectionName = section.Name,
                    Address = item.Address,
                    City = item.City,
                    Country = item.Country,
                    Id = item.Id

                });

            }

            return listData;
        }

        public StudentAndGuardViewModel GetStudentAndGuardian(int id)
        {
            var studAndGuardVM = new StudentAndGuardViewModel();
            var studData = _context.Students.SingleOrDefault(c => c.Id == id);
            var guardData = _context.Guardian.SingleOrDefault(c => c.Id == id);

            studAndGuardVM.Id = studData.Id;
            studAndGuardVM.FirstName = studData.FirstName;
            studAndGuardVM.LastName = studData.LastName;
            studAndGuardVM.Email = studData.Email;
            studAndGuardVM.CNIC = studData.CNIC;
            studAndGuardVM.Dob = studData.Dob;
            studAndGuardVM.Country = studData.Country;
            studAndGuardVM.ClassId = studData.ClassId;
            studAndGuardVM.Address = studData.Address;
            studAndGuardVM.MobileNO = studData.MobileNO;
            studAndGuardVM.Gender = studData.Gender;
            studAndGuardVM.City = studData.City;

            studAndGuardVM.GFirstName = guardData.FirstName;
            studAndGuardVM.GLastName = guardData.LastName;
            studAndGuardVM.GCNIC = guardData.CNIC;
            studAndGuardVM.GMobileNo = guardData.MobileNo;
            studAndGuardVM.GAddress = guardData.Address;
            studAndGuardVM.GuardianType = guardData.GuardianType;

            return studAndGuardVM;
        }

        public StudentAndGuardViewModel Insert(StudentAndGuardViewModel studentAndGuardViewModel)
        {
            var students = new Student();
            var guardian = new Guardian();

            students.FirstName = studentAndGuardViewModel.FirstName;
            students.LastName = studentAndGuardViewModel.LastName;
            students.Email = studentAndGuardViewModel.Email;
            students.CNIC = studentAndGuardViewModel.CNIC;
            students.MobileNO = studentAndGuardViewModel.MobileNO;
            students.Gender = studentAndGuardViewModel.Gender;
            students.Address = studentAndGuardViewModel.Address;
            students.Dob = studentAndGuardViewModel.Dob;
            students.ClassId = studentAndGuardViewModel.ClassId;
            students.SectionId = studentAndGuardViewModel.SectionId;
            students.City = studentAndGuardViewModel.City;
            students.Country = studentAndGuardViewModel.Country;
            students.CreatedOn = DateTime.Now;
            students.UpdatedOn = DateTime.Now;

            guardian.FirstName = studentAndGuardViewModel.FirstName;
            guardian.LastName = studentAndGuardViewModel.LastName;
            guardian.CNIC = studentAndGuardViewModel.CNIC;
            guardian.Address = studentAndGuardViewModel.Address;
            guardian.MobileNo = studentAndGuardViewModel.MobileNO;
            guardian.CreatedOn = DateTime.Now;
            guardian.UpdatedOn = DateTime.Now;
            guardian.GuardianType = studentAndGuardViewModel.GuardianType;


            if (studentAndGuardViewModel.Id > 0)
            {
                var std = _context.Students.FirstOrDefault(x => x.Id == studentAndGuardViewModel.Id);
                var g = _context.Guardian.FirstOrDefault(x => x.StudentId == std.Id);

                std.Id = studentAndGuardViewModel.Id;
                std.FirstName = studentAndGuardViewModel.FirstName;
                std.LastName = studentAndGuardViewModel.LastName;
                std.Email = studentAndGuardViewModel.Email;
                std.MobileNO = studentAndGuardViewModel.MobileNO;
                std.CNIC = studentAndGuardViewModel.CNIC;
                std.Gender = studentAndGuardViewModel.Gender;
                std.Address = studentAndGuardViewModel.Address;
                std.Dob = studentAndGuardViewModel.Dob;
                std.City = studentAndGuardViewModel.City;
                std.Country = studentAndGuardViewModel.Country;

                g.FirstName = studentAndGuardViewModel.GFirstName;
                g.LastName = studentAndGuardViewModel.GLastName;
                g.CNIC = studentAndGuardViewModel.GCNIC;
                g.Address = studentAndGuardViewModel.GAddress;
                g.MobileNo = studentAndGuardViewModel.GMobileNo;
                g.GuardianType = studentAndGuardViewModel.GuardianType;

                _context.Students.Update(std);
                _context.Guardian.Update(g);

            }
            else
            {
                var result = _context.Students.Add(students);
                _context.SaveChanges();

                guardian.StudentId = result.Entity.Id;
                _context.Guardian.Add(guardian);

                //


            }

            _context.SaveChanges();


            return studentAndGuardViewModel;
        }
        public List<StudentAndGuardViewModel> GetAllStudentByClass(int id)
        {
            var listData = new List<StudentAndGuardViewModel>();
            var list = _context.Students.Where(x => x.ClassId == id).ToList();
            foreach (var item in list)
            {

                listData.Add(new StudentAndGuardViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CNIC = item.CNIC,
                    MobileNO = item.MobileNO,
                    Gender = item.Gender,
                    Dob = item.Dob,
                    ClassId = item.ClassId,
                    Address = item.Address,
                    City = item.City,
                    Country = item.Country,
                    Id = item.Id

                });



            }

            return listData;
        }
    }
}

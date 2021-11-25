using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Teachers
{
    public class TeacherRep : ITeacherRep
    {
        private readonly StudentDbContext _context;

        public TeacherRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<SectionViewModel> GetAllSectionsByClass(int id)
        {
            var listData = new List<SectionViewModel>();
            var list = _context.Sections.Where(x => x.ClassId == id).ToList();
            foreach (var item in list)
            {

                listData.Add(new SectionViewModel()
                {
                    Name = item.Name,

                    ClassId = item.ClassId,

                    Id = item.Id

                });



            }

            return listData;
        }
        public List<TeacherViewModel> GetAllTeacher()
        {
            var listData = new List<TeacherViewModel>();
            var list = _context.Teachers.ToList();
            foreach (var item in list)
            {
                listData.Add(new TeacherViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Address = item.Address,
                    Dob = item.Dob,
                    ContactNo = item.ContactNo,
                    Id = item.Id,
                    CreatedOn = item.CreatedOn,
                    CreatedBy = item.CreatedBy,
                    CreatedIP = item.CreatedIP
                });



            }

            return listData;
        }
        public void DeleteTeacher(int? id)
        {
            var teacher = _context.Teachers.Find(id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }
        public TeacherViewModel GetTeacher(int id)
        {
            var teacherVM = new TeacherViewModel();
            var data = _context.Teachers.SingleOrDefault(c => c.Id == id);

            teacherVM.Id = data.Id;
            teacherVM.FirstName = data.FirstName;
            teacherVM.LastName = data.LastName;
            teacherVM.Email = data.Email;
            teacherVM.Address = data.Address;
            teacherVM.Dob = data.Dob;
            teacherVM.ContactNo = data.ContactNo;
            teacherVM.CreatedBy = data.CreatedBy;
            teacherVM.CreatedIP = data.CreatedIP;
            teacherVM.CreatedOn = data.CreatedOn;

            return teacherVM;
        }
        public TeacherViewModel AddOrEditTeacher(TeacherViewModel teacherVM)
        {

            var teacher = new Teacher();
            teacher.FirstName = teacherVM.FirstName;
            teacher.LastName = teacherVM.LastName;
            teacher.Email = teacherVM.Email;
            teacher.Address = teacherVM.Address;
            teacher.Dob = teacherVM.Dob;
            teacher.ContactNo = teacherVM.ContactNo;
            teacher.Id = teacherVM.Id;
            teacher.CreatedOn = DateTime.Now;
            teacher.CreatedBy = 1;
            teacher.CreatedIP = "67676";

            if (teacherVM.Id > 0)
            {

                _context.Teachers.Update(teacher);
            }
            else
            {

                _context.Teachers.Add(teacher);

            }

            _context.SaveChanges();


            return teacherVM;
        }
    }
}

using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Teachers
{
    public interface ITeacherRep
    {
        List<TeacherViewModel> GetAllTeacher();
        void DeleteTeacher(int? id);
        TeacherViewModel GetTeacher(int id);
        TeacherViewModel AddOrEditTeacher(TeacherViewModel teacherViewModel);
    }
}

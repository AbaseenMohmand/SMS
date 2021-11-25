using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Students
{
  public  interface IStudentRep
    {
        List<StudentAndGuardViewModel> GetAllStudent();
        StudentAndGuardViewModel Insert(StudentAndGuardViewModel studentAndGuardViewModel);
        StudentAndGuardViewModel GetStudentAndGuardian(int id);
        void DeleteStudent(int? id);
        List<StudentAndGuardViewModel> GetAllStudentByClass(int id);

    }
}

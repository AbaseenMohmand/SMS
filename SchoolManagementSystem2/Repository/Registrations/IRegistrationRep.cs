using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Registrations
{
   
    public interface IRegistrationRep
    {
        List<StudentViewModel> GetAll();
        StudentViewModel AddOrEdit(StudentViewModel studentViewModel);
        StudentViewModel GetByName(int id);
        void Delete(int? id);
    }
}

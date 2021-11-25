using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Class
{
    public interface IClassRep
    {
        List<ClassViewModel> GetAllClass();
        void DeleteClass(int? id);
        ClassViewModel GetClass(int id);
        ClassViewModel AddOrEditClass(ClassViewModel classViewModel);
    }
}

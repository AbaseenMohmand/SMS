using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Sections
{
   public interface ISectionRep
    {
        List<SectionViewModel> GetAllSection();
        void DeleteSection(int? id);
        SectionViewModel GetSection(int id);
        SectionViewModel AddOrEditSection(SectionViewModel sectionViewModel);
    }
}

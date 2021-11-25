using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SchoolManagementSystem2.Repository.Sections
{
    public class SectionRep : ISectionRep
    {

        private readonly StudentDbContext _context;


        public SectionRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<SectionViewModel> GetAllSection()
        {
            var listData = new List<SectionViewModel>();
            var list = _context.Sections.ToList();
            foreach (var item in list)
            {
                var classes = _context.Classes.FirstOrDefault(x => x.Id == item.ClassId);
                listData.Add(new SectionViewModel()
                {
                    Name = item.Name,
                    Id = item.Id,
                    ClassName = classes.Name,
                    ClassId = item.ClassId,
                    CreatedBy = item.CreatedBy,
                    CreatedOn = item.CreatedOn,
                    UpdatedOn = item.UpdatedOn

                });



            }

            return listData;
        }
        public void DeleteSection(int? id)
        {
            var sections = _context.Sections.Find(id);
            _context.Sections.Remove(sections);
            _context.SaveChanges();
        }
        public SectionViewModel GetSection(int id)
        {
            var sectionVM = new SectionViewModel();
            var data = _context.Sections.SingleOrDefault(c => c.Id == id);

            sectionVM.Id = data.Id;
            sectionVM.Name = data.Name;
            sectionVM.ClassId = data.ClassId;
            sectionVM.CreatedBy = data.CreatedBy;
            sectionVM.CreatedOn = data.CreatedOn;
            sectionVM.UpdatedOn = data.UpdatedOn;

            return sectionVM;
        }

        public SectionViewModel AddOrEditSection(SectionViewModel sectionVM)
        {
            var section = new Section();
            section.Name = sectionVM.Name;
            section.Id = sectionVM.Id;
            section.CreatedBy = 1;
            section.CreatedOn = DateTime.Now;
            section.UpdatedOn = DateTime.Now;
            section.ClassId = sectionVM.ClassId;

            if (sectionVM.Id > 0)
            {
                var data = _context.Sections.FirstOrDefault(x => x.Id == sectionVM.Id);
                data.Id = sectionVM.Id;
                data.Name = sectionVM.Name;
                data.UpdatedOn = DateTime.Now;
                data.ClassId = sectionVM.ClassId;

                _context.Sections.Update(data);
            }
            else
            {

                _context.Sections.Add(section);

            }

            _context.SaveChanges();


            return sectionVM;
        }
    }
}

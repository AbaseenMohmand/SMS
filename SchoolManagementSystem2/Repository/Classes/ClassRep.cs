using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Class
{
    public class ClassRep : IClassRep
    {
        private readonly StudentDbContext _context;


        public ClassRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<ClassViewModel> GetAllClass()
        {
            var listData = new List<ClassViewModel>();
            var list = _context.Classes.ToList();
            foreach (var item in list)
            {
                listData.Add(new ClassViewModel()
                {
                    Name = item.Name,
                    Id = item.Id,
                    CreatedBy = item.CreatedBy,
                    CreatedOn = item.CreatedOn,
                    UpdatedOn = item.UpdatedOn

                });



            }

            return listData;
        }

        public void DeleteClass(int? id)
        {
            var classes = _context.Classes.Find(id);
            _context.Classes.Remove(classes);
            _context.SaveChanges();
        }

        public ClassViewModel GetClass(int id)
        {
            var classesVM = new ClassViewModel();
            var data = _context.Classes.SingleOrDefault(c => c.Id == id);

            classesVM.Id = data.Id;
            classesVM.Name = data.Name;
            classesVM.UpdatedOn = data.UpdatedOn;
            classesVM.CreatedBy = data.CreatedBy;
            classesVM.CreatedOn = data.CreatedOn;

            return classesVM;
        }
        public ClassViewModel AddOrEditClass(ClassViewModel classVM)
        {

            var classes = new Classs();
            classes.Name = classVM.Name;
            classes.Id = classVM.Id;
            classes.CreatedBy = 1;
            classes.CreatedOn = DateTime.Now;
            classes.UpdatedOn = DateTime.Now;

            if (classVM.Id > 0)
            {

                _context.Classes.Update(classes);
            }
            else
            {

                _context.Classes.Add(classes);

            }

            _context.SaveChanges();


            return classVM;
        }
    }
}

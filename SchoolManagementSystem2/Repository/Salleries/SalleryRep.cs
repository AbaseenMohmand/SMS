using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Salleries
{
    public class SalleryRep : ISalleryRep
    {
        private readonly StudentDbContext _context;


        public SalleryRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<SalleryViewModel> GetAllSallery()
        {
            var listData = new List<SalleryViewModel>();
            var list = _context.Salleries.ToList();
            foreach (var item in list)
            {
                var employeeName = "";
                var employeetype = _context.EmployeeTypes.FirstOrDefault(x => x.Id == item.EmployeeType);
                var months = _context.Months.FirstOrDefault(x => x.Id == item.MonthId);
                if (employeetype.Name == "Teacher")
                {
                    var data = _context.Teachers.FirstOrDefault(x => x.Id == item.EmployeeId);
                    employeeName = data.FirstName + " " + data.LastName;
                }

                if (employeetype.Name == "Employee")
                {
                    var data = _context.Employees.FirstOrDefault(x => x.Id == item.EmployeeId);
                    employeeName = data.FirstName + " " + data.LastName;
                }

                listData.Add(new SalleryViewModel()
                {
                    Amount = item.Amount,
                    Id = item.Id,
                    EmployeeType = item.EmployeeType,
                    EmployeeTypeName = employeetype.Name,
                    EmployeeName = employeeName,
                    MonthId = item.MonthId,
                    Month = months.Name

                });



            }

            return listData;
        }

        public void DeleteSallery(int? id)
        {
            var sallery = _context.Salleries.Find(id);
            _context.Salleries.Remove(sallery);
            _context.SaveChanges();
        }

        public SalleryViewModel GetSallery(int id)
        {
            var salleryVM = new SalleryViewModel();
            var data = _context.Salleries.SingleOrDefault(c => c.Id == id);

            salleryVM.Id = data.Id;
            salleryVM.EmployeeId = data.EmployeeId;
            salleryVM.MonthId = data.MonthId;


            return salleryVM;
        }
        public SalleryViewModel AddOrEditSallery(SalleryViewModel salleryViewModel)
        {
            var sallery = new Sallery();
            sallery.Id = salleryViewModel.Id;

            sallery.EmployeeId = salleryViewModel.EmployeeId;
            sallery.EmployeeType = salleryViewModel.EmployeeType;

            sallery.MonthId = salleryViewModel.MonthId;

            if (salleryViewModel.Id > 0)
            {
                var data = _context.Salleries.FirstOrDefault(x => x.Id == salleryViewModel.Id);

                data.Id = salleryViewModel.Id;

                data.EmployeeId = salleryViewModel.EmployeeId;
                data.EmployeeType = salleryViewModel.EmployeeType;

                data.MonthId = salleryViewModel.MonthId;

                _context.Salleries.Update(data);

            }

            else
            {

                _context.Salleries.Add(sallery);

            }

            _context.SaveChanges();


            return salleryViewModel;
        }
    }
}

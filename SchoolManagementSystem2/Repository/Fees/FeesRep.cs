using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Fees
{
    public class FeesRep : IFeesRep
    {
        private readonly StudentDbContext _context;

        public FeesRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<FeeViewModel> GetAllFee()
        {
            var listData = new List<FeeViewModel>();
            var list = _context.Fees.ToList();
            foreach (var item in list)
            {
                var classes = _context.Classes.FirstOrDefault(x => x.Id == item.ClassId);
                var student = _context.Students.FirstOrDefault(x => x.Id == item.StudentId);
                var months = _context.Months.FirstOrDefault(x => x.Id == item.MonthId);
                listData.Add(new FeeViewModel()
                {
                    Amount = item.Amount,
                    Id = item.Id,
                    ClassName = classes.Name,
                    ClassId = item.ClassId,
                    StudentName = student.FirstName,
                    StudentId = item.StudentId,
                    MonthId = item.MonthId,
                    Month = months.Name

                });



            }

            return listData;
        }
        public void DeleteFee(int? id)
        {
            var fees = _context.Fees.Find(id);
            _context.Fees.Remove(fees);
            _context.SaveChanges();
        }
        public FeeViewModel GetFee(int id)
        {
            var feeVM = new FeeViewModel();
            var data = _context.Fees.SingleOrDefault(c => c.Id == id);

            feeVM.Id = data.Id;
            feeVM.MonthId = data.MonthId;
            feeVM.StudentId = data.StudentId;
            feeVM.ClassId = data.ClassId;
            feeVM.Amount = data.Amount;

            return feeVM;
        }

        public FeeViewModel AddOrEditFee(FeeViewModel feeViewModel)
        {
            var fee = new Fee();
            fee.Id = feeViewModel.Id;
            fee.Amount = feeViewModel.Amount;
            fee.ClassId = feeViewModel.ClassId;
            fee.StudentId = feeViewModel.StudentId;
            fee.MonthId = feeViewModel.MonthId;

            if (feeViewModel.Id > 0)
            {
                var data = _context.Fees.FirstOrDefault(x => x.Id == feeViewModel.Id);

                data.Id = feeViewModel.Id;
                data.Amount = feeViewModel.Amount;
                data.ClassId = feeViewModel.ClassId;
                data.StudentId = feeViewModel.StudentId;
                data.MonthId = feeViewModel.MonthId;

                _context.Fees.Update(data);

            }

            else
            {

                _context.Fees.Add(fee);

            }

            _context.SaveChanges();


            return feeViewModel;
        }
    }
}

using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Months
{
    public class MonthRep : IMonthRep
    {
        private readonly StudentDbContext _context;


        public MonthRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<MonthViewModel> GetAllMonth()
        {
            var listData = new List<MonthViewModel>();
            var list = _context.Months.ToList();
            foreach (var item in list)
            {
                listData.Add(new MonthViewModel()
                {
                    Name = item.Name,
                    Id = item.Id,


                });



            }

            return listData;
        }
    }
}

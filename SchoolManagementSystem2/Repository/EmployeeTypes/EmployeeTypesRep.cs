using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.EmployeeTypes
{
    public class EmployeeTypesRep : IEmployeeTypesRep
    {
        private readonly StudentDbContext _context;


        public EmployeeTypesRep(StudentDbContext context)
        {
            _context = context;

        }
        public List<EmployeeTypeViewModel> GetAllEmployeeType()
        {
            var listData = new List<EmployeeTypeViewModel>();
            var list = _context.EmployeeTypes.ToList();
            foreach (var item in list)
            {
                listData.Add(new EmployeeTypeViewModel()
                {
                    Name = item.Name,
                    Id = item.Id,


                });



            }

            return listData;
        }
    }
}

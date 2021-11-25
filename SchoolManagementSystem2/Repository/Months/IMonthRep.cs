using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Months
{
    public interface IMonthRep
    {
        List<MonthViewModel> GetAllMonth();
    }
}

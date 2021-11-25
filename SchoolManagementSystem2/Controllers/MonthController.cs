using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Months;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Controllers
{
    public class MonthController : Controller
    {
        private readonly IMonthRep _interfaceMonth;

        public MonthController(IMonthRep interfaceMonth)
        {
            _interfaceMonth = interfaceMonth;


        }
        public IActionResult Index()
        {
            var Getall = _interfaceMonth.GetAllMonth();



            return View(Getall);
        }
    }
}

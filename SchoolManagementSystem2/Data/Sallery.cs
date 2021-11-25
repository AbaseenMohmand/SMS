using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data
{
    public class Sallery
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int AmountType { get; set; }
        public int EmployeeType { get; set; }
        public int EmployeeId { get; set; }
        public int MonthId { get; set; }
        public DateTime DatePay { get; set; }

    }
}

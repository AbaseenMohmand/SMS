using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class SalleryViewModel
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int AmountType { get; set; }
        public string EmployeeTypeName { get; set; }
        public int EmployeeType { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int MonthId { get; set; }
        public string Month { get; set; }
        public DateTime DatePay { get; set; }
        
    }
}

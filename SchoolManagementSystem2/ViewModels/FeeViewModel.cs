using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class FeeViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int MonthId { get; set; }
        public string Month { get; set; }
    }
}

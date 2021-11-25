using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data
{
    public class Fee
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public int MonthId { get; set; }
       // public string Month { get; set; }

    }
}

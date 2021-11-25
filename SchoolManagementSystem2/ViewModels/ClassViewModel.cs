using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class ClassViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

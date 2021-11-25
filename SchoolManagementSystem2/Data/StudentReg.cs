using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Models
{
    public class StudentReg
    {
        
        public string SchoolName { get; set; }

        
        public string Email { get; set; }
        
        public string Password { get; set; }

      
        public string ConfirmPassword { get; set; }
       
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedIP { get; set; }
    }
}

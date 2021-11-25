using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data
{
    public class Guardian
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
        public int CNIC { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }
        public int GuardianType { get; set; }
        public int StudentId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

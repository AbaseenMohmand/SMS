using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CNIC { get; set; }
        public int MobileNO { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

using SchoolManagementSystem2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class StudentAndGuardViewModel 
    {

        public string ClassName { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CNIC { get; set; }
        public int MobileNO { get; set; }
        public string Gender  { get; set; }
        public string Dob { get; set; }

        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string GFirstName { get; set; }
        public string GLastName { get; set; }
        public int GCNIC { get; set; }
        public int GMobileNo { get; set; }
        public string GAddress { get; set; }
        public int GuardianType { get; set; }



}
}

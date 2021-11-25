using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class TeacherViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public int ContactNo { get; set; }

        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedIP { get; set; }
    }
}

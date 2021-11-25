using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedIP { get; set; }
    }
}

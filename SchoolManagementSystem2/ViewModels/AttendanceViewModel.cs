using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.ViewModels
{
    public class AttendanceViewModel
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int AttendaceId { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string AttendanceType { get; set; }

        public DateTime Date { get; set; }
    }
}

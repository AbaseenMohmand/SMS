using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Data
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int AttendaceId { get; set; }
        public int SectionId { get; set; }
        public string AttendanceType { get; set; }

        public DateTime Date { get; set; }
    }
}

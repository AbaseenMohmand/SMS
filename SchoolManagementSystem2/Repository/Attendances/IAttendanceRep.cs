using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Attendances
{
   public interface IAttendanceRep
    {

        List<AttendanceViewModel> GetAllAttendance();
        void DeleteAttendance(int? id);
        AttendanceViewModel GetAttendance(int id);
        AttendanceViewModel AddOrEditAttendance(AttendanceViewModel feeViewModel);
        List<SectionViewModel> GetAllSectionsByClass(int id);
        List<AttendanceViewModel> GetStudentForAttendance(int ClassId, int SectionId);
    }
}

using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Attendances
{
    public class AttendanceRep : IAttendanceRep
    {

        private readonly StudentDbContext _context;

        public AttendanceRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<AttendanceViewModel> GetAllAttendance()
        {
            var listData = new List<AttendanceViewModel>();
            var list = _context.Attendances.ToList();
            foreach (var item in list)
            {
                listData.Add(new AttendanceViewModel()
                {
                    Id = item.Id,
                    StudentId = item.StudentId,
                    ClassId = item.ClassId,
                    SectionId = item.SectionId,
                    AttendaceId = item.AttendaceId,
                    Date = item.Date,
                    AttendanceType = item.AttendanceType

                });

            }
            return listData;
        }

        public List<SectionViewModel> GetAllSectionsByClass(int id)
        {
            var listData = new List<SectionViewModel>();
            var list = _context.Sections.Where(x => x.ClassId == id).ToList();
            foreach (var item in list)
            {

                listData.Add(new SectionViewModel()
                {
                    Name = item.Name,

                    ClassId = item.ClassId,

                    Id = item.Id

                });



            }

            return listData;
        }
        public void DeleteAttendance(int? id)
        {
            var attendance = _context.Attendances.Find(id);
            _context.Attendances.Remove(attendance);
            _context.SaveChanges();
        }
        public AttendanceViewModel GetAttendance(int id)
        {
            var AttendanceVM = new AttendanceViewModel();
            var data = _context.Attendances.SingleOrDefault(c => c.Id == id);

            AttendanceVM.Id = data.Id;
            AttendanceVM.StudentId = data.StudentId;
            AttendanceVM.ClassId = data.ClassId;
            AttendanceVM.SectionId = data.SectionId;
            AttendanceVM.AttendaceId = data.AttendaceId;
            AttendanceVM.AttendanceType = data.AttendanceType;
            AttendanceVM.Date = data.Date;

            return AttendanceVM;
        }
        public AttendanceViewModel AddOrEditAttendance(AttendanceViewModel AttendanceVM)
        {
            var attendance = new Attendance();
            attendance.AttendaceId = AttendanceVM.AttendaceId;
            attendance.Id = AttendanceVM.Id;
            attendance.SectionId = AttendanceVM.SectionId;
            attendance.StudentId = AttendanceVM.StudentId;
            attendance.ClassId = AttendanceVM.ClassId;
            attendance.AttendanceType = AttendanceVM.AttendanceType;
            attendance.Date = DateTime.Now;

            if (AttendanceVM.Id > 0)
            {
                var data = _context.Attendances.FirstOrDefault(x => x.Id == AttendanceVM.Id);

                data.AttendaceId = AttendanceVM.AttendaceId;
                data.Id = AttendanceVM.Id;
                data.SectionId = AttendanceVM.SectionId;
                data.StudentId = AttendanceVM.StudentId;
                data.ClassId = AttendanceVM.ClassId;
                data.AttendanceType = AttendanceVM.AttendanceType;
                data.Date = DateTime.Now;

                _context.Attendances.Update(data);

            }

            else
            {

                _context.Attendances.Add(attendance);

            }

            _context.SaveChanges();


            return AttendanceVM;
        }
        public List<AttendanceViewModel> GetStudentForAttendance(int ClassId, int SectionId)
        {


            var listData = new List<AttendanceViewModel>();
            var std = _context.Students.Where(x => x.ClassId == ClassId && x.SectionId == SectionId).ToList();

            foreach (var item in std)
            {

                listData.Add(new AttendanceViewModel()
                {

                    StudentName = item.FirstName + " " + item.LastName,

                    ClassId = item.ClassId,

                    SectionId = item.SectionId,

                    Id = item.Id,



                });
            }
            return listData;
        }
    }
}

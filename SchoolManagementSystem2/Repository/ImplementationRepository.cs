 
using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SchoolManagementSystem2.Repository
{
    public class ImplementationRepository : InterfaceRegistration
    {
        private readonly StudentDbContext _context;
        

        public ImplementationRepository(StudentDbContext context)
        {
            _context = context;
            
        }
        //public StudentViewModel AddOrEdit(StudentViewModel studentVM)
        //{

        //    var studentReg = new StudentReg();
        //    studentReg.SchoolName = studentVM.SchoolName;
        //    studentReg.Email = studentVM.Email;
        //    studentReg.Password = studentVM.Password;
        //    studentReg.ConfirmPassword = studentVM.ConfirmPassword;
        //    studentReg.Id = studentVM.Id;
        //    studentReg.CreatedOn = DateTime.Now;
        //    studentReg.CreatedBy = 1;
        //    studentReg.CreatedIP = "67676";



        //    if(studentVM.Id > 0)
        //    {

        //        _context.Registration.Update(studentReg);
        //    }
        //    else
        //    {
        //        // var result= _context.Students.Add(studentReg);
        //        _context.Registration.Add(studentReg);
        //        // G.firstNAme= vm.GfirstNAme;
        //        //G.StudentId = result.Id
        //        // var result= _context.Guardians.Add(guard);
        //        //


        //    }

        //    _context.SaveChanges();


        //    return studentVM;
        //}

        //public AttendanceViewModel AddOrEditAttendance(AttendanceViewModel AttendanceVM)
        //{
        //    var attendance = new Attendance();
        //    attendance.AttendaceId = AttendanceVM.AttendaceId;
        //    attendance.Id = AttendanceVM.Id;
        //    attendance.SectionId = AttendanceVM.SectionId;
        //    attendance.StudentId = AttendanceVM.StudentId;
        //    attendance.ClassId = AttendanceVM.ClassId;
        //    attendance.AttendanceType = AttendanceVM.AttendanceType;
        //    attendance.Date = DateTime.Now;

        //    if (AttendanceVM.Id > 0)
        //    {
        //        var data = _context.Attendances.FirstOrDefault(x => x.Id == AttendanceVM.Id);

        //        data.AttendaceId = AttendanceVM.AttendaceId;
        //        data.Id = AttendanceVM.Id;
        //        data.SectionId = AttendanceVM.SectionId;
        //        data.StudentId = AttendanceVM.StudentId;
        //        data.ClassId = AttendanceVM.ClassId;
        //        data.AttendanceType = AttendanceVM.AttendanceType;
        //        data.Date = DateTime.Now;

        //        _context.Attendances.Update(data);

        //    }

        //    else
        //    {

        //        _context.Attendances.Add(attendance);

        //    }

        //    _context.SaveChanges();


        //    return AttendanceVM;
        //}

        //public ClassViewModel AddOrEditClass(ClassViewModel classVM)
        //{

        //    var classes = new Class();
        //    classes.Name = classVM.Name;
        //    classes.Id = classVM.Id;
        //    classes.CreatedBy = 1;
        //    classes.CreatedOn = DateTime.Now;
        //    classes.UpdatedOn = DateTime.Now;

        //    if (classVM.Id > 0)
        //    {

        //        _context.Classes.Update(classes);
        //    }
        //    else
        //    {

        //        _context.Classes.Add(classes);

        //    }

        //    _context.SaveChanges();


        //    return classVM;
        //}

        //public FeeViewModel AddOrEditFee(FeeViewModel feeViewModel)
        //{
        //    var fee = new Fee();
        //    fee.Id = feeViewModel.Id;
        //    fee.Amount = feeViewModel.Amount;
        //    fee.ClassId = feeViewModel.ClassId;
        //    fee.StudentId = feeViewModel.StudentId;
        //    fee.MonthId = feeViewModel.MonthId;

        //    if (feeViewModel.Id > 0)
        //    {
        //        var data = _context.Fees.FirstOrDefault(x => x.Id == feeViewModel.Id);

        //        data.Id = feeViewModel.Id;
        //        data.Amount = feeViewModel.Amount;
        //        data.ClassId = feeViewModel.ClassId;
        //        data.StudentId = feeViewModel.StudentId;
        //        data.MonthId = feeViewModel.MonthId;

        //        _context.Fees.Update(data);

        //    }

        //    else
        //    {

        //        _context.Fees.Add(fee);

        //    }

        //    _context.SaveChanges();


        //    return feeViewModel;
        //}

        //public SectionViewModel AddOrEditSection(SectionViewModel sectionVM)
        //{
        //    var section = new Section();
        //    section.Name = sectionVM.Name;
        //    section.Id = sectionVM.Id;
        //    section.CreatedBy = 1;
        //    section.CreatedOn = DateTime.Now;
        //    section.UpdatedOn = DateTime.Now;
        //    section.ClassId = sectionVM.ClassId;

        //    if (sectionVM.Id > 0)
        //    {
        //        var data = _context.Sections.FirstOrDefault(x => x.Id == sectionVM.Id);
        //        data.Id = sectionVM.Id;
        //        data.Name = sectionVM.Name;
        //        data.UpdatedOn = DateTime.Now;
        //        data.ClassId = sectionVM.ClassId;

        //        _context.Sections.Update(data);
        //    }
        //    else
        //    {

        //        _context.Sections.Add(section);

        //    }

        //    _context.SaveChanges();


        //    return sectionVM;
        //}

        //public TeacherViewModel AddOrEditTeacher(TeacherViewModel teacherVM)
        //{

        //    var teacher = new Teacher();
        //    teacher.FirstName = teacherVM.FirstName;
        //    teacher.LastName = teacherVM.LastName;
        //    teacher.Email = teacherVM.Email;
        //    teacher.Address = teacherVM.Address;
        //    teacher.Dob = teacherVM.Dob;
        //    teacher.ContactNo = teacherVM.ContactNo;
        //    teacher.Id = teacherVM.Id;
        //    teacher.CreatedOn = DateTime.Now;
        //    teacher.CreatedBy = 1;
        //    teacher.CreatedIP = "67676";

        //    if (teacherVM.Id > 0)
        //    {

        //        _context.Teachers.Update(teacher);
        //    }
        //    else
        //    {

        //        _context.Teachers.Add(teacher);

        //    }

        //    _context.SaveChanges();


        //    return teacherVM;
        //}

        //public void Delete(int? id)
        //{
        //    var student =  _context.Registration.Find(id);
        //               _context.Registration.Remove(student);
        //               _context.SaveChanges();


        //}

        //public void DeleteAttendance(int? id)
        //{
        //    var attendance = _context.Attendances.Find(id);
        //    _context.Attendances.Remove(attendance);
        //    _context.SaveChanges();
        //}

        //public void DeleteClass(int? id)
        //{
        //    var classes = _context.Classes.Find(id);
        //    _context.Classes.Remove(classes);
        //    _context.SaveChanges();
        //}

        //public void DeleteFee(int? id)
        //{
        //    var fees = _context.Fees.Find(id);
        //    _context.Fees.Remove(fees);
        //    _context.SaveChanges();
        //}

        //public void DeleteSection(int? id)
        //{
        //    var sections = _context.Sections.Find(id);
        //    _context.Sections.Remove(sections);
        //    _context.SaveChanges();
        //}

        //public void DeleteStudent(int? id)
        //{
        //    var student = _context.Students.Find(id);
        //    _context.Students.Remove(student);
        //    _context.SaveChanges();


        //}

        //public void DeleteTeacher(int? id)
        //{
        //    var teacher = _context.Teachers.Find(id);
        //    _context.Teachers.Remove(teacher);
        //    _context.SaveChanges();
        //}

        //public List<StudentViewModel> GetAll()
        //{
        //    var listData = new List<StudentViewModel>();
        //    var list = _context.Registration.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new StudentViewModel()
        //        {
        //            SchoolName = item.SchoolName,
        //            Email = item.Email,
        //            Password = item.Password,
        //            ConfirmPassword = item.ConfirmPassword,
        //            Id = item.Id,
        //            CreatedOn = item.CreatedOn,
        //            CreatedBy = item.CreatedBy,
        //            CreatedIP = item.CreatedIP
        //        });



        //    }

        //    return listData;
        //}

        //public List<AttendanceViewModel> GetAllAttendance()
        //{
        //    var listData = new List<AttendanceViewModel>();
        //    var list = _context.Attendances.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new AttendanceViewModel()
        //        {
        //            Id = item.Id,
        //            StudentId = item.StudentId,
        //            ClassId = item.ClassId,
        //            SectionId = item.SectionId,
        //           AttendaceId = item.AttendaceId,
        //           Date = item.Date,
        //           AttendanceType = item.AttendanceType

        //        });

        //    }
        //    return listData;
        //}
        //public List<ClassViewModel> GetAllClass()
        //{
        //    var listData = new List<ClassViewModel>();
        //    var list = _context.Classes.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new ClassViewModel()
        //        {
        //            Name = item.Name,
        //            Id = item.Id,
        //            CreatedBy = item.CreatedBy,
        //            CreatedOn = item.CreatedOn,
        //            UpdatedOn = item.UpdatedOn

        //        });



        //    }

        //    return listData;
        //}

        //public List<FeeViewModel> GetAllFee()
        //{
        //    var listData = new List<FeeViewModel>();
        //    var list = _context.Fees.ToList();
        //    foreach (var item in list)
        //    {
        //        var classes = _context.Classes.FirstOrDefault(x => x.Id == item.ClassId);
        //        var student = _context.Students.FirstOrDefault(x => x.Id == item.StudentId);
        //        var months = _context.Months.FirstOrDefault(x => x.Id == item.MonthId);
        //        listData.Add(new FeeViewModel()
        //        {
        //            Amount = item.Amount,
        //            Id = item.Id,
        //            ClassName = classes.Name,
        //            ClassId = item.ClassId,
        //            StudentName = student.FirstName,
        //            StudentId = item.StudentId,
        //            MonthId = item.MonthId,
        //            Month = months.Name

        //        });



        //    }

        //    return listData;
        //}

        //public List<SectionViewModel> GetAllSection()
        //{
        //    var listData = new List<SectionViewModel>();
        //    var list = _context.Sections.ToList();
        //    foreach (var item in list)
        //    {
        //        var classes = _context.Classes.FirstOrDefault(x=>x.Id== item.ClassId);
        //        listData.Add(new SectionViewModel()
        //        {
        //            Name = item.Name,
        //            Id = item.Id,
        //            ClassName = classes.Name,
        //            ClassId = item.ClassId,
        //            CreatedBy = item.CreatedBy,
        //            CreatedOn = item.CreatedOn,
        //            UpdatedOn = item.UpdatedOn

        //        });



        //    }

        //    return listData;
        //}

        //public List<StudentAndGuardViewModel> GetAllStudent()
        //{
        //    var listData = new List<StudentAndGuardViewModel>();
        //    var list = _context.Students.ToList();
        //    foreach (var item in list)
        //    {
        //        var classes = _context.Classes.FirstOrDefault(x => x.Id == item.ClassId);
        //        var section = _context.Sections.FirstOrDefault(x => x.Id == item.SectionId);
        //        listData.Add(new StudentAndGuardViewModel()
        //        {
        //            FirstName = item.FirstName,
        //            LastName=item.LastName,
        //            Email = item.Email,
        //            CNIC = item.CNIC,
        //            MobileNO = item.MobileNO,
        //            Gender = item.Gender,
        //            Dob = item.Dob,                   
        //            ClassId = item.ClassId,
        //            ClassName =classes.Name,
        //            SectionId = item.SectionId,
        //            SectionName=section.Name,
        //            Address = item.Address,
        //            City = item.City,
        //            Country = item.Country,
        //            Id =item.Id

        //        });



        //    }

        //    return listData;
        //}
        //public List<StudentAndGuardViewModel> GetAllStudentByClass(int id)
        //{
        //    var listData = new List<StudentAndGuardViewModel>();
        //    var list = _context.Students.Where(x=>x.ClassId==id).ToList();
        //    foreach (var item in list)
        //    {

        //        listData.Add(new StudentAndGuardViewModel()
        //        {
        //            FirstName = item.FirstName,
        //            LastName = item.LastName,
        //            Email = item.Email,
        //            CNIC = item.CNIC,
        //            MobileNO = item.MobileNO,
        //            Gender = item.Gender,
        //            Dob = item.Dob,
        //            ClassId = item.ClassId,
        //            Address = item.Address,
        //            City = item.City,
        //            Country = item.Country,
        //            Id = item.Id

        //        });



        //    }

        //    return listData;
        //}

        //public List<SectionViewModel> GetAllSectionsByClass(int id)
        //{
        //    var listData = new List<SectionViewModel>();
        //    var list = _context.Sections.Where(x => x.ClassId == id).ToList();
        //    foreach (var item in list)
        //    {

        //        listData.Add(new SectionViewModel()
        //        {
        //            Name = item.Name,

        //            ClassId = item.ClassId,

        //            Id = item.Id

        //        });



        //    }

        //    return listData;
        //}
        //public List<TeacherViewModel> GetAllTeacher()
        //{
        //    var listData = new List<TeacherViewModel>();
        //    var list = _context.Teachers.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new TeacherViewModel()
        //        {
        //            FirstName = item.FirstName,
        //            LastName = item.LastName,
        //            Email = item.Email,
        //            Address = item.Address,
        //            Dob = item.Dob,
        //            ContactNo = item.ContactNo,
        //            Id = item.Id,
        //            CreatedOn = item.CreatedOn,
        //            CreatedBy = item.CreatedBy,
        //            CreatedIP = item.CreatedIP
        //        });



        //    }

        //    return listData;
        //}

        //public AttendanceViewModel GetAttendance(int id)
        //{
        //    var AttendanceVM = new AttendanceViewModel();
        //    var data = _context.Attendances.SingleOrDefault(c => c.Id == id);

        //    AttendanceVM.Id = data.Id;
        //    AttendanceVM.StudentId = data.StudentId;
        //    AttendanceVM.ClassId = data.ClassId;
        //    AttendanceVM.SectionId = data.SectionId;
        //    AttendanceVM.AttendaceId = data.AttendaceId;
        //    AttendanceVM.AttendanceType = data.AttendanceType;
        //    AttendanceVM.Date = data.Date;

        //    return AttendanceVM;
        //}

        //public StudentViewModel GetByName(int id)
        //{
        //    var StudentVM = new StudentViewModel();
        //    var data = _context.Registration.SingleOrDefault(c => c.Id == id);

        //    StudentVM.SchoolName = data.SchoolName;
        //    StudentVM.Email = data.Email;
        //    StudentVM.Password = data.Password;
        //    StudentVM.ConfirmPassword = data.ConfirmPassword;
        //    StudentVM.Id = data.Id;
        //    StudentVM.CreatedOn = data.CreatedOn;
        //    StudentVM.CreatedBy = data.CreatedBy;
        //    StudentVM.CreatedIP = data.CreatedIP;

        //    return StudentVM;
        //}

        //public ClassViewModel GetClass(int id)
        //{
        //    var classesVM = new ClassViewModel();
        //    var data = _context.Classes.SingleOrDefault(c => c.Id == id);

        //    classesVM.Id = data.Id;
        //    classesVM.Name = data.Name;
        //    classesVM.UpdatedOn = data.UpdatedOn;
        //    classesVM.CreatedBy = data.CreatedBy;
        //    classesVM.CreatedOn = data.CreatedOn;

        //    return classesVM;
        //}

        //public FeeViewModel GetFee(int id)
        //{
        //    var feeVM = new FeeViewModel();
        //    var data = _context.Fees.SingleOrDefault(c => c.Id == id);

        //    feeVM.Id = data.Id;
        //    feeVM.MonthId = data.MonthId;
        //    feeVM.StudentId = data.StudentId;
        //    feeVM.ClassId = data.ClassId;
        //    feeVM.Amount = data.Amount;

        //    return feeVM;
        //}

        //public SectionViewModel GetSection(int id)
        //{
        //    var sectionVM = new SectionViewModel();
        //    var data = _context.Sections.SingleOrDefault(c => c.Id == id);

        //    sectionVM.Id = data.Id;
        //    sectionVM.Name = data.Name;
        //    sectionVM.ClassId = data.ClassId;
        //    sectionVM.CreatedBy = data.CreatedBy;
        //    sectionVM.CreatedOn = data.CreatedOn;
        //    sectionVM.UpdatedOn = data.UpdatedOn;

        //    return sectionVM;
        //}

        //public StudentAndGuardViewModel GetStudentAndGuardian(int id)
        //{
        //    var studAndGuardVM = new StudentAndGuardViewModel();
        //    var studData =  _context.Students.SingleOrDefault(c => c.Id == id);
        //    var guardData = _context.Guardian.SingleOrDefault(c => c.Id == id);

        //    studAndGuardVM.Id = studData.Id;
        //    studAndGuardVM.FirstName = studData.FirstName;
        //    studAndGuardVM.LastName = studData.LastName;
        //    studAndGuardVM.Email = studData.Email;
        //    studAndGuardVM.CNIC = studData.CNIC;
        //    studAndGuardVM.Dob = studData.Dob;
        //    studAndGuardVM.Country = studData.Country;
        //    studAndGuardVM.ClassId = studData.ClassId;
        //    studAndGuardVM.Address = studData.Address;
        //    studAndGuardVM.MobileNO = studData.MobileNO;
        //    studAndGuardVM.Gender = studData.Gender;
        //    studAndGuardVM.City = studData.City;

        //    studAndGuardVM.GFirstName = guardData.FirstName;
        //    studAndGuardVM.GLastName = guardData.LastName;
        //    studAndGuardVM.GCNIC = guardData.CNIC;
        //    studAndGuardVM.GMobileNo = guardData.MobileNo;
        //    studAndGuardVM.GAddress = guardData.Address;
        //    studAndGuardVM.GuardianType = guardData.GuardianType;

        //    return studAndGuardVM;
        //}

        //public TeacherViewModel GetTeacher(int id)
        //{
        //    var teacherVM = new TeacherViewModel();
        //    var data = _context.Teachers.SingleOrDefault(c => c.Id == id);

        //    teacherVM.Id = data.Id;
        //    teacherVM.FirstName = data.FirstName;
        //    teacherVM.LastName = data.LastName;
        //    teacherVM.Email = data.Email;
        //    teacherVM.Address = data.Address;
        //    teacherVM.Dob = data.Dob;
        //    teacherVM.ContactNo = data.ContactNo;
        //    teacherVM.CreatedBy = data.CreatedBy;
        //    teacherVM.CreatedIP = data.CreatedIP;
        //    teacherVM.CreatedOn = data.CreatedOn;

        //    return teacherVM;
        //}

        //public StudentAndGuardViewModel Insert(StudentAndGuardViewModel studentAndGuardViewModel)
        //{
        //    var students = new Student();
        //    var guardian = new Guardian();

        //    students.FirstName = studentAndGuardViewModel.FirstName;
        //    students.LastName = studentAndGuardViewModel.LastName;
        //    students.Email = studentAndGuardViewModel.Email;
        //    students.CNIC = studentAndGuardViewModel.CNIC;
        //    students.MobileNO = studentAndGuardViewModel.MobileNO;
        //    students.Gender = studentAndGuardViewModel.Gender;
        //    students.Address = studentAndGuardViewModel.Address;
        //    students.Dob = studentAndGuardViewModel.Dob;
        //    students.ClassId = studentAndGuardViewModel.ClassId;
        //    students.SectionId = studentAndGuardViewModel.SectionId;
        //    students.City = studentAndGuardViewModel.City;
        //    students.Country = studentAndGuardViewModel.Country;
        //    students.CreatedOn = DateTime.Now;
        //    students.UpdatedOn = DateTime.Now;

        //    guardian.FirstName = studentAndGuardViewModel.FirstName;
        //    guardian.LastName = studentAndGuardViewModel.LastName;
        //    guardian.CNIC = studentAndGuardViewModel.CNIC;
        //    guardian.Address = studentAndGuardViewModel.Address;
        //    guardian.MobileNo = studentAndGuardViewModel.MobileNO;
        //    guardian.CreatedOn = DateTime.Now;
        //    guardian.UpdatedOn = DateTime.Now;
        //    guardian.GuardianType = studentAndGuardViewModel.GuardianType;


        //    if (studentAndGuardViewModel.Id>0)
        //    {
        //        var std = _context.Students.FirstOrDefault(x => x.Id == studentAndGuardViewModel.Id);
        //        var g = _context.Guardian.FirstOrDefault(x => x.StudentId == std.Id);

        //        std.Id = studentAndGuardViewModel.Id;
        //        std.FirstName = studentAndGuardViewModel.FirstName;
        //        std.LastName = studentAndGuardViewModel.LastName;
        //        std.Email = studentAndGuardViewModel.Email;
        //        std.MobileNO = studentAndGuardViewModel.MobileNO;
        //        std.CNIC = studentAndGuardViewModel.CNIC;
        //        std.Gender = studentAndGuardViewModel.Gender;
        //        std.Address = studentAndGuardViewModel.Address;
        //        std.Dob = studentAndGuardViewModel.Dob;
        //        std.City = studentAndGuardViewModel.City;
        //        std.Country = studentAndGuardViewModel.Country;

        //        g.FirstName = studentAndGuardViewModel.GFirstName;
        //        g.LastName = studentAndGuardViewModel.GLastName;
        //        g.CNIC = studentAndGuardViewModel.GCNIC;
        //        g.Address = studentAndGuardViewModel.GAddress;
        //        g.MobileNo = studentAndGuardViewModel.GMobileNo;
        //        g.GuardianType = studentAndGuardViewModel.GuardianType;

        //        _context.Students.Update(std);
        //        _context.Guardian.Update(g);

        //    }
        //    else
        //    {
        //       var result= _context.Students.Add(students);
        //        _context.SaveChanges();

        //        guardian.StudentId = result.Entity.Id;
        //        _context.Guardian.Add(guardian);

        //        //


        //    }

        //    _context.SaveChanges();


        //    return studentAndGuardViewModel;
        //}

        //public List<AttendanceViewModel> GetStudentForAttendance(int ClassId, int SectionId)
        //{
        //    var listData = new List<AttendanceViewModel>();
        //    var std = _context.Students.Where(x => x.ClassId == ClassId && x.SectionId == SectionId).ToList();

        //    foreach (var item in std)
        //    {

        //        listData.Add(new AttendanceViewModel()
        //        {

        //            StudentName = item.FirstName + " " + item.LastName,

        //            ClassId = item.ClassId,

        //            SectionId = item.SectionId,

        //            Id = item.Id,



        //        });
        //    }
        //    return listData;
        //}

        //public List<EmployeeViewModel> GetAllEmployee()
        //{
        //    var listData = new List<EmployeeViewModel>();
        //    var list = _context.Employees.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new EmployeeViewModel()
        //        {
        //            FirstName = item.FirstName,
        //            LastName = item.LastName,
        //            Email = item.Email,
        //            Address = item.Address,
        //            Dob = item.Dob,
        //            Designation=item.Designation,
        //            ContactNo = item.ContactNo,
        //            Id = item.Id,
        //            CreatedOn = item.CreatedOn,
        //            CreatedBy = item.CreatedBy,
        //            CreatedIP = item.CreatedIP
        //        });



        //    }

        //    return listData;
        //}

        //public void DeleteEmployee(int? id)
        //{
        //    var employee = _context.Employees.Find(id);
        //    _context.Employees.Remove(employee);
        //    _context.SaveChanges();
        //}

        //public EmployeeViewModel GetEmployee(int id)
        //{
        //    var employeeVM = new EmployeeViewModel();
        //    var data = _context.Employees.SingleOrDefault(c => c.Id == id);

        //    employeeVM.Id = data.Id;
        //    employeeVM.FirstName = data.FirstName;
        //    employeeVM.LastName = data.LastName;
        //    employeeVM.Email = data.Email;
        //    employeeVM.Address = data.Address;
        //    employeeVM.Dob = data.Dob;
        //    employeeVM.Designation = data.Designation;
        //    employeeVM.ContactNo = data.ContactNo;
        //    employeeVM.CreatedBy = data.CreatedBy;
        //    employeeVM.CreatedIP = data.CreatedIP;
        //    employeeVM.CreatedOn = data.CreatedOn;

        //    return employeeVM;
        //}

        //public EmployeeViewModel AddOrEditEmployee(EmployeeViewModel employeeViewModel)
        //{
        //    var employee = new Employee();
        //    employee.FirstName = employeeViewModel.FirstName;
        //    employee.LastName = employeeViewModel.LastName;
        //    employee.Email = employeeViewModel.Email;
        //    employee.Address = employeeViewModel.Address;
        //    employee.Dob = employeeViewModel.Dob;
        //    employee.Designation = employeeViewModel.Designation;
        //    employee.ContactNo = employeeViewModel.ContactNo;
        //    employee.Id = employeeViewModel.Id;
        //    employee.CreatedOn = DateTime.Now;
        //    employee.CreatedBy = 1;
        //    employee.CreatedIP = "67676";

        //    if (employeeViewModel.Id > 0)
        //    {

        //        _context.Employees.Update(employee);
        //    }
        //    else
        //    {

        //        _context.Employees.Add(employee);

        //    }

        //    _context.SaveChanges();


        //    return employeeViewModel;
        //}

        //public List<MonthViewModel> GetAllMonth()
        //{
        //    var listData = new List<MonthViewModel>();
        //    var list = _context.Months.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new MonthViewModel()
        //        {
        //            Name = item.Name,
        //            Id = item.Id,


        //        });



        //    }

        //    return listData;
        //}

        //public List<SalleryViewModel> GetAllSallery()
        //{
        //    var listData = new List<SalleryViewModel>();
        //    var list = _context.Salleries.ToList();
        //    foreach (var item in list)
        //    {
        //        var employeeName = "";
        //        var employeetype = _context.EmployeeTypes.FirstOrDefault(x => x.Id == item.EmployeeType);
        //        var months = _context.Months.FirstOrDefault(x => x.Id == item.MonthId);
        //        if(employeetype.Name  == "Teacher")
        //        {
        //            var data = _context.Teachers.FirstOrDefault(x => x.Id == item.EmployeeId);
        //            employeeName = data.FirstName + " " + data.LastName;
        //        }

        //        if (employeetype.Name == "Employee")
        //        {
        //            var data = _context.Employees.FirstOrDefault(x => x.Id == item.EmployeeId);
        //            employeeName = data.FirstName + " " + data.LastName;
        //        }

        //        listData.Add(new SalleryViewModel()
        //        {
        //            Amount = item.Amount,
        //            Id = item.Id,
        //            EmployeeType = item.EmployeeType,
        //            EmployeeTypeName = employeetype.Name,
        //            EmployeeName = employeeName,
        //            MonthId = item.MonthId,
        //            Month = months.Name

        //        }); 



        //    }

        //    return listData;
        //}

        //public void DeleteSallery(int? id)
        //{
        //    var sallery = _context.Salleries.Find(id);
        //    _context.Salleries.Remove(sallery);
        //    _context.SaveChanges();
        //}

        //public SalleryViewModel GetSallery(int id)
        //{
        //    var salleryVM = new SalleryViewModel();
        //    var data = _context.Salleries.SingleOrDefault(c => c.Id == id);

        //    salleryVM.Id = data.Id;
        //    salleryVM.EmployeeId = data.EmployeeId;
        //    salleryVM.MonthId = data.MonthId;


        //    return salleryVM;
        //}

        //public SalleryViewModel AddOrEditSallery(SalleryViewModel salleryViewModel)
        //{
        //    var sallery = new Sallery();
        //    sallery.Id = salleryViewModel.Id;

        //    sallery.EmployeeId = salleryViewModel.EmployeeId;
        //    sallery.EmployeeType = salleryViewModel.EmployeeType;

        //    sallery.MonthId = salleryViewModel.MonthId;

        //    if (salleryViewModel.Id > 0)
        //    {
        //        var data = _context.Salleries.FirstOrDefault(x => x.Id == salleryViewModel.Id);

        //        data.Id = salleryViewModel.Id;

        //        data.EmployeeId = salleryViewModel.EmployeeId;
        //        data.EmployeeType = salleryViewModel.EmployeeType;

        //        data.MonthId = salleryViewModel.MonthId;

        //        _context.Salleries.Update(data);

        //    }

        //    else
        //    {

        //        _context.Salleries.Add(sallery);

        //    }

        //    _context.SaveChanges();


        //    return salleryViewModel;
        //}

        //public List<EmployeeTypeViewModel> GetAllEmployeeByType(int typeId)
        //{
        //    var list = new List<EmployeeTypeViewModel>();
        //    if (typeId == 1)
        //    {
        //        var employee = _context.Employees.ToList();
        //        foreach (var item in employee)
        //        {
        //            list.Add(new EmployeeTypeViewModel()
        //            {
        //                Id = item.Id,
        //                Name = item.FirstName + " " + item.LastName,
        //            });
        //        }
        //    }

        //    else
        //    {
        //        var teacher = _context.Teachers.ToList();
        //        foreach (var item in teacher)
        //        {
        //            list.Add(new EmployeeTypeViewModel()
        //            {
        //                Id = item.Id,
        //                Name = item.FirstName + " " + item.LastName,
        //            });
        //        }
        //    }

        //    return list;
        //}

        //public List<EmployeeTypeViewModel> GetAllEmployeeType()
        //{
        //    var listData = new List<EmployeeTypeViewModel>();
        //    var list = _context.EmployeeTypes.ToList();
        //    foreach (var item in list)
        //    {
        //        listData.Add(new EmployeeTypeViewModel()
        //        {
        //            Name = item.Name,
        //            Id = item.Id,


        //        });



        //    }

        //    return listData;
        //}
        //public List<AttendanceViewModel> GetAllSectionsByClass(int classid, int sectionId)
        //{
        //    var listData = new List<AttendanceViewModel>()
        //   var std= _context.Studdents.where(x=>x.classsId== classId && x.sectionId== sectionId).toList();
        //    foreach (var item in std)
        //    {

        //        listData.Add(new AttendanceViewModel()
        //        {
        //            Name = item.FirstName +" "+item.LastName,

        //            ClassId = item.ClassId,

        //            Id = item.Id

        //        });



        //    }

        //    return listData;
        //}

    }
}

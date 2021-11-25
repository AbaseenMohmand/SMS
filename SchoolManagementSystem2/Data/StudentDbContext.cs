using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Models
{
    public class StudentDbContext : IdentityDbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
                
        }
       

        public DbSet<StudentReg> Registration { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Guardian> Guardian { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Classs> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Sallery> Salleries { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }

    }
}

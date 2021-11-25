using SchoolManagementSystem2.Data;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Employees
{
    public class EmployeeRep:IEmployeeRep
    {
        private readonly StudentDbContext _context;


        public EmployeeRep(StudentDbContext context)
        {
            _context = context;

        }

        public List<EmployeeViewModel> GetAllEmployee()
        {
            var listData = new List<EmployeeViewModel>();
            var list = _context.Employees.ToList();
            foreach (var item in list)
            {
                listData.Add(new EmployeeViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Address = item.Address,
                    Dob = item.Dob,
                    Designation = item.Designation,
                    ContactNo = item.ContactNo,
                    Id = item.Id,
                    CreatedOn = item.CreatedOn,
                    CreatedBy = item.CreatedBy,
                    CreatedIP = item.CreatedIP
                });



            }

            return listData;
        }

        public List<EmployeeTypeViewModel> GetAllEmployeeByType(int typeId)
        {
            var list = new List<EmployeeTypeViewModel>();
            if (typeId == 1)
            {
                var employee = _context.Employees.ToList();
                foreach (var item in employee)
                {
                    list.Add(new EmployeeTypeViewModel()
                    {
                        Id = item.Id,
                        Name = item.FirstName + " " + item.LastName,
                    });
                }
            }

            else
            {
                var teacher = _context.Teachers.ToList();
                foreach (var item in teacher)
                {
                    list.Add(new EmployeeTypeViewModel()
                    {
                        Id = item.Id,
                        Name = item.FirstName + " " + item.LastName,
                    });
                }
            }

            return list;
        }

        public void DeleteEmployee(int? id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public EmployeeViewModel GetEmployee(int id)
        {
            var employeeVM = new EmployeeViewModel();
            var data = _context.Employees.SingleOrDefault(c => c.Id == id);

            employeeVM.Id = data.Id;
            employeeVM.FirstName = data.FirstName;
            employeeVM.LastName = data.LastName;
            employeeVM.Email = data.Email;
            employeeVM.Address = data.Address;
            employeeVM.Dob = data.Dob;
            employeeVM.Designation = data.Designation;
            employeeVM.ContactNo = data.ContactNo;
            employeeVM.CreatedBy = data.CreatedBy;
            employeeVM.CreatedIP = data.CreatedIP;
            employeeVM.CreatedOn = data.CreatedOn;

            return employeeVM;
        }
        public EmployeeViewModel AddOrEditEmployee(EmployeeViewModel employeeViewModel)
        {
            var employee = new Employee();
            employee.FirstName = employeeViewModel.FirstName;
            employee.LastName = employeeViewModel.LastName;
            employee.Email = employeeViewModel.Email;
            employee.Address = employeeViewModel.Address;
            employee.Dob = employeeViewModel.Dob;
            employee.Designation = employeeViewModel.Designation;
            employee.ContactNo = employeeViewModel.ContactNo;
            employee.Id = employeeViewModel.Id;
            employee.CreatedOn = DateTime.Now;
            employee.CreatedBy = 1;
            employee.CreatedIP = "67676";

            if (employeeViewModel.Id > 0)
            {

                _context.Employees.Update(employee);
            }
            else
            {

                _context.Employees.Add(employee);

            }

            _context.SaveChanges();


            return employeeViewModel;
        }
    }
}

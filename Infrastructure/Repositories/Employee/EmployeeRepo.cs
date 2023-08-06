using Data;
using Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AttendanceContext Context;

        public EmployeeRepo(AttendanceContext Context)
        {
            this.Context = Context;
        }
        public async Task<Employee> Add(EmployeeDto dto)
        {
            var Emp = new Employee()
            {
                Fname = dto.Fname,
                Lname = dto.Lname,
                DateOfHiring = dto.DateOfHiring,
                DepartmentId = dto.DepartmentId,
                SupervisiorId = dto.SupervisiorId
            };

            await Context.AddAsync(Emp);
            Context.SaveChanges();
            return Emp;
        }

        public Task<List<Employee>> GetAll()
        {
            var Employees = Context.Employee.ToListAsync();
            return Employees;

        }
    }
}

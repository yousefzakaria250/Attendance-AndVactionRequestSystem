using Data;
using Infrastructure.Dtos;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
       private readonly AttendanceContext Context;

        public DepartmentRepo(AttendanceContext Context)
        {
            this.Context = Context;
        }

        public async Task<dynamic> Add(DepartmentDto dto)
        {
            var Dept = new Department
            {
                Name = dto.Name
            };
            await Context.AddAsync(Dept);
            Context.SaveChanges();
            return Dept; 
        }
    }
}

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
    public class RequestRepo : IRequestRepo
    {

        private readonly AttendanceContext attendanceContext;

        public RequestRepo(AttendanceContext attendanceContext)
        {
            this.attendanceContext = attendanceContext;
        }

        public async Task<Request> Add(RequestDto dto)
        {
            var request = new Request()
            {
                 From = dto.From ,
                 To = dto.To ,
                 Reason = dto.Reason ,
                 State = dto.State ,
                 EmployeeId  = dto.EmployeeId 
            };

            await attendanceContext.AddAsync(request);
            attendanceContext.SaveChanges();
            return request;
        }

        public async Task<List<Request>> GetAllRequestOfSupervisior(int departmentNo)
        {
            var requests = await attendanceContext.Request
                .Where(w => w.DepartmentId == departmentNo && w.State == 0)
                .ToListAsync();
            return requests;
        }

        public async Task<Request> ChangeRequestStateBySupervisior(int Id, int State)
        {
            if (State != 1)
                State = -1 ;
            var request = await Get(Id);
            request.State = State;
            attendanceContext.Entry(request).State = EntityState.Modified;
            attendanceContext.SaveChanges();
            return request; 
            
        }

        public async Task<Request> Get(int Id) 
        {
            var request = await attendanceContext.Request.FirstOrDefaultAsync(f => f.Id == Id);
            return request;
        }

        public async Task<Request> ChangeRequestStateByGM(int Id, int State)
        {

            if (State != 2)
                State = -1;
            var request = await Get(Id);
            request.State = State;
            attendanceContext.Entry(request).State = EntityState.Modified;
            attendanceContext.SaveChanges();
            return request;
        }

        public async Task<List<Request>> GetAllRequestOfGM(int departmentNo)
        {
            var requests = await attendanceContext.Request
              .Where(w => w.DepartmentId == departmentNo && w.State == 1)
              .ToListAsync();
            return requests;

    }

        public async Task<Request> Delete(int Id)
        {
            var request = await Get(Id);
            attendanceContext.Entry(request).State = EntityState.Deleted;
            attendanceContext.SaveChanges();
            return request;

        }
    }
}

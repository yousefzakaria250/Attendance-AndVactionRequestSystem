using Data;
using Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRequestRepo
    {
        public Task<Request> Add(RequestDto dto);
        public Task<List<Request>> GetAllRequestOfSupervisior(int departmentNo);
        public Task<List<Request>> GetAllRequestOfGM(int departmentNo);
        public Task<Request> Get(int Id);
        public Task<Request> ChangeRequestStateBySupervisior(int Id , int State);
        public Task<Request> ChangeRequestStateByGM(int Id, int State);
        public Task<Request> Delete(int Id);

    }
}

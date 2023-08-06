using Infrastructure.Dtos;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendaceBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepo departmentRepo;

        public DepartmentController(IDepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }

        [HttpPost("AddDepatment")]
        public async Task<IActionResult> Add( DepartmentDto dto)
        {
            var res = departmentRepo.Add(dto);
            return Ok(res);

        }
    }
}

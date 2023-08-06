using Infrastructure;
using Infrastructure.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendaceBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepo employeeRepo;

        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        [HttpPost("AddEmployee")]

        public async Task<IActionResult> Add(EmployeeDto dto)
        { 
            var Emp = await employeeRepo.Add(dto);
            return Ok(Emp);
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            var emp = await employeeRepo.GetAll();
            return Ok(emp);

        }
    }
}

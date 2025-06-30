using dotNetCoreApp.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            // var details = await _context.EmployeDetails.ToListAsync();
            return Ok("details");
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllEmployeeDetails()
        {
            var items = new List<EmployeeDetail>
            {
            new EmployeeDetail
            {
                Department = "IT",
                Email = "john.doe@example.com",
                EmployeeID = 1
            },
            new EmployeeDetail
            {
                Department = "HR",
                Email = "jane.smith@example.com",
                EmployeeID = 2
            },
            new EmployeeDetail
            {
                Department = "Finance",
                Email = "mike.brown@example.com",
                EmployeeID = 3
            }
            };

            return Ok(items);
        }
    }
}
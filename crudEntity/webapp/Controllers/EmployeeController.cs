using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using DAL;
namespace webapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    
        private readonly webappContext _dbContext;

       public EmployeeController(webappContext dbContext)
        {
            _dbContext = dbContext;
        }


    [HttpGet]
        [Route("GetEmployees")]   
    public IActionResult GetEmployees() { 
            List<Employee> list = _dbContext.Employees.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }


[HttpPost]
        // [Route("PostEmployees")]
    public IActionResult PostEmployees(Employee emp) { 
            _dbContext.Add(emp);
            _dbContext.SaveChanges();
            return Ok(emp);
            
        }
}

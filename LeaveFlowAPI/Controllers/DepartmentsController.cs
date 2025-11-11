using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveFlowAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeaveFlowAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly PresenceDbContext _context;

        public DepartmentsController(PresenceDbContext context)
        {
            _context = context;
        }

        // GET: /api/departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            var departments = await _context.Departments
                                            .Include(d => d.Manager)
                                            .Include(d => d.Employees)
                                            .ToListAsync();
            return Ok(departments);
        }

        // GET: /api/departments/1/employees
        [HttpGet("{id}/employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesForDepartment(int id)
        {
            var employees = await _context.Employees
                                          .Where(e => e.DepartmentId == id)
                                          .ToListAsync();
            return Ok(employees);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesDetailsController : ControllerBase
    {
        private readonly EmployeesDetailsContext _context;

        public EmployeesDetailsController(EmployeesDetailsContext context)
        {
            _context = context;
        }

        // GET: api/EmployeesDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeesDetails>>> GetEmployeesDetails()
        {
            return await _context.EmployeesDetails.ToListAsync();
        }

        // GET: api/EmployeesDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeesDetails>> GetEmployeesDetails(int id)
        {
            var employeesDetails = await _context.EmployeesDetails.FindAsync(id);

            if (employeesDetails == null)
            {
                return NotFound();
            }

            return employeesDetails;
        }

        // PUT: api/EmployeesDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeesDetails(int id, EmployeesDetails employeesDetails)
        {
            if (id != employeesDetails.EmployeesDetailId)
            {
                return BadRequest();
            }

            _context.Entry(employeesDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployeesDetails
        [HttpPost]
        public async Task<ActionResult<EmployeesDetails>> PostEmployeesDetails(EmployeesDetails employeesDetails)
        {
            _context.EmployeesDetails.Add(employeesDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeesDetails", new { id = employeesDetails.EmployeesDetailId }, employeesDetails);
        }

        // DELETE: api/EmployeesDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeesDetails(int id)
        {
            var employeesDetails = await _context.EmployeesDetails.FindAsync(id);
            if (employeesDetails == null)
            {
                return NotFound();
            }

            _context.EmployeesDetails.Remove(employeesDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeesDetailsExists(int id)
        {
            return _context.EmployeesDetails.Any(e => e.EmployeesDetailId == id);
        }
    }
}

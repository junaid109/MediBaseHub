using Microsoft.AspNetCore.Mvc;
using MediHub.Shared.Models;
using MediHub.Database;
using Microsoft.EntityFrameworkCore;

namespace MediHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly MediHubContext _context;
        public PatientsController(MediHubContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients() =>
            await _context.Patients.ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            patient.Id = Guid.NewGuid();
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPatients), new { id = patient.Id }, patient);
        }
    }
}
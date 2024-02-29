using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly AppContext _context;

        public TeachersController(AppContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetTeacherByStudentName([FromQuery] string? name)
        {

            if (_context.Teacher == null)
            {
                return NotFound();
            }
            if (string.IsNullOrEmpty(name))
            {
                return Ok(await _context.Teacher.ToListAsync());
            }
            var teachers = await _context.Pupil.Where(x=>x.FirstName==name).Select(x=>x.Teachers).ToListAsync(); 

            if (teachers == null)
            {
                return NotFound();
            }

            return Ok(teachers);
        }
    }
}

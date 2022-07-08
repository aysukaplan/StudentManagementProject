using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
	 	private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public IEnumerable<Student> GetStudents()
        { 
			return _context.GetStudents();
    
        }

    }

}


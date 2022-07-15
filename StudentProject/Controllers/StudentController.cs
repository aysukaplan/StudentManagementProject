using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using System;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]

    public class StudentController : ControllerBase
    {
	 	private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        //get all students
        [HttpGet()]
        public List<Student> GetStudents()
        { 
			return _context.GetStudents();
    
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return _context.GetStudents().Where(x => x.Id == id).FirstOrDefault();
            return _context.GetStudents().Where(x => x.Id == id).FirstOrDefault();
        }



    }

}


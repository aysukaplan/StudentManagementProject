using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;
using System;

  
namespace StudentProject.Controllers
{   
    [Route("api/Students")]
    [ApiController]
   

    public class StudentController : ControllerBase
    {
	 	private readonly StudentFileOperations _context;

        public StudentController(StudentFileOperations context)
        {
            _context = context;
        }

        //get all students
        [HttpGet()]
        public List<Student> GetStudents()
        {
            List<Student> students = _context.GetStudentList();
            return students;
    
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id) //null check
        {
            return _context.GetStudentList().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

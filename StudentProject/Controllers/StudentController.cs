using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;
using System;

  
namespace StudentProject.Controllers
{   
  
    [ApiController]
    [Route("[controllers]")]
   
   
    public class StudentController : ControllerBase
    {
	 	private readonly StudentFileOperations _context;

        public StudentController(StudentFileOperations context)
        {
            _context = context;
        }

        //get all students
        [HttpGet()]
        public List<Person> GetStudents()
        {
            List<Person> students = _context.GetList();
            return students;
    
        }
/*
        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return _context.GetStudents().Where(x => x.Id == id).FirstOrDefault();
            return _context.GetStudents().Where(x => x.Id == id).FirstOrDefault();
        }


*/
    }

}

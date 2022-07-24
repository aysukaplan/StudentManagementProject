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
        [HttpGet()]
        public List<Student> GetStudents()
        {
            return new StudentFileOperations().GetStudentList();
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id) 
        {
            return new StudentFileOperations().GetStudentById(id);
        }
    }
}

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
        //get all students
        [HttpGet()]
        public List<Student> GetStudents()
        {
            List<Student> students = new StudentFileOperations().GetStudentList();
            return students;
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id) //null check
        {
            return new StudentFileOperations().GetStudentList().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;

namespace StudentProject.Controllers
{
    [Route("api/Teachers")]
    [ApiController]
  
    public class TeacherController : ControllerBase
    {
        //get all teachers
        [HttpGet()]
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new TeacherFileOperations().GetTeacherList();
            return teachers;
    
        }

        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            return new TeacherFileOperations().GetTeacherList().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
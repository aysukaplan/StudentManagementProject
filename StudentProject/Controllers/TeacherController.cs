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
        
        [HttpGet()]
        public List<Teacher> GetTeachers()
        {
            return new TeacherFileOperations().GetTeacherList();
        }

        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            return new TeacherFileOperations().GetTeacherById(id);
        }
    }
}
using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]

    public class TeacherController : ControllerBase
    {


        [HttpGet()]
        public IEnumerable<Student> GetTeachers()
        {
            return;

        }

        [HttpGet("{id}")]
        public IActionResult GetTeacher(int id)
        {
            return;
        }
    }
}
using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]


    public class TeacherController : ControllerBase
    {


        [HttpGet()]
        public List<Teacher> GetTeachers()
        {
            return;

        }

        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            return;
        }
    }
}
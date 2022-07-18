using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]


    public class TeacherController : ControllerBase
    {
        private readonly TeacherFileOperations _context;

        public TeacherController(TeacherFileOperations context)
        {
            _context = context;
        }

        //get all teachers
        [HttpGet()]
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = _context.GetTeacherList();
            return teachers;
    
        }

        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            return _context.GetTeacherList().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
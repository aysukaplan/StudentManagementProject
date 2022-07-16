using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]

    public class AdminController : ControllerBase
    {
        /*
        [HttpGet()]
        public List<Admin> GetAdmins()
        {
            return;

        }

        [HttpGet("{id}")]
        public Admin GetAdmin(int id)
        {
            return;
        }

        /*
        [HttpPost] //bu yanlış oldu gibi diğerlerine de route yazmalıyım

        public IActionResult AddAdmin([FromBody] Admin newAdmin)
        {
            //Check if the admin exists
            //If there is a admin with same name
            return BadRequest();

            //If there is not a admin with same name 
            //add admin to admin list
            return Ok();
        }

        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            //Check if the student exists
            //If there is a student with same name
            return BadRequest();

            //If there is not a student with same name 
            //add student to student list
            return Ok();
        }
        public IActionResult AddTeacher([FromBody] Teacher newTeacher)
        {
            //Check if the teacher exists
            //If there is a teacher with same name
            return BadRequest();

            //If there is not a teacher with same name 
            //add teacher to teacher list
            return Ok();
        }

        //put methods to here


        [HttpDelete("{adminId}")]

        //deleting an admin
        public IActionResult DeleteAdmin(int adminId)
        {
            //check if the admin is in the admin list
            //if not send bad request 
            return BadRequest();

            //if admin with given id is in admin list
            //check if there is another admin in list besides given admin
            //if there is not other admin 
            return BadRequest(); //or send another error code
            //else
            return Ok();
        }

        [HttpDelete("{studentId}")]

        //deleting a student
        public IActionResult DeleteStudent(int studentId)
        {
            //check if the student is in the student list
            //if not send bad request 
            return BadRequest();

            //if student with given id is in student list
            return Ok();
        }
        [HttpDelete("{teacherId}")]

        //deleting a teacher
        public IActionResult DeleteTeacher(int teacherId)
        {
            //check if the teacher is in the teacher list
            //if not send bad request 
            return BadRequest();

            //if teacher with given id is in teacher list
            return Ok();
        }

        //[HttpDelete] //delete all students?
        //[HttpDelete] //delete all teachers?
        */
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;

namespace StudentProject.Controllers
{
    [Route("api/Admins")]
    [ApiController]

    public class AdminController : ControllerBase
    {
        [HttpGet()]
        public List<Admin> GetAdmins()
        {
            return new AdminFileOperations().GetAdminList(); 
        }

        [HttpGet("{id}")]
        public Admin GetAdmin(int id)
        {
            return new AdminFileOperations().GetAdminById(id);
        }
    
        [HttpPost("{AdminId}/Admin")] 
        public IActionResult AddAdmin([FromBody] Admin newAdmin)
        {
            //Check if the admin exists
             var admin = new AdminFileOperations().GetAdminById(newAdmin.Id);
            //If there is a admin with same name
            if(admin is not null)
                return BadRequest();

            //If there is not a admin with same name 
            //add admin to admin txt
            new AdminFileOperations().Write(newAdmin.ToString());
            return Ok();
        }

        [HttpPost("{AdminId}/Student")]
        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            var student = new StudentFileOperations().GetStudentById(newStudent.Id);
            
            if(student is not null)
                return BadRequest();

            new StudentFileOperations().Write(newStudent.ToString());
            return Ok();
        }

        [HttpPost("{AdminId}/Teacher")]
        public IActionResult AddTeacher([FromBody] Teacher newTeacher)
        {
            var teacher = new TeacherFileOperations().GetTeacherById(newTeacher.Id);
         
            if(teacher is not null)
                return BadRequest();

            new TeacherFileOperations().Write(newTeacher.ToString());
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id,[FromBody] Admin updatedAdmin)
        {
            var admin = new AdminFileOperations().GetAdminById(updatedAdmin.Id);
          
            if(admin is null)
                return BadRequest();

            //admin to line
            string DeletedLine = admin.ToString();
            //delete existing admin line form text
            new AdminFileOperations().DeleteLine(DeletedLine);

            //checking if the name etc is updated or not
            admin.Name = updatedAdmin.Name != default ? updatedAdmin.Name: admin.Name; 
            admin.Id = updatedAdmin.Id != default ? updatedAdmin.Id : admin.Id;
            admin.Email = updatedAdmin.Email != default ? updatedAdmin.Email : admin.Email;
            admin.Birthday = updatedAdmin.Birthday != default ? updatedAdmin.Birthday : admin.Birthday;

            //write updated admin to the text
            string line = admin.ToString();
            new AdminFileOperations().Write(line);
            return Ok();
        }

        [HttpPut("{AdminId}/Students/{id}")]
        public IActionResult UpdateStudent(int id,[FromBody] Student updatedStudent)
        {
            var student = new StudentFileOperations().GetStudentById(updatedStudent.Id);
          
            if(student is null)
                return BadRequest();

            //delete existing student line form text
            string DeletedLine = student.ToString();
            new StudentFileOperations().DeleteLine(DeletedLine);

            student.Name = updatedStudent.Name != default ? updatedStudent.Name: student.Name; 
            student.Id = updatedStudent.Id != default ? updatedStudent.Id : student.Id;
            student.Email = updatedStudent.Email != default ? updatedStudent.Email : student.Email;
            student.Birthday = updatedStudent.Birthday != default ? updatedStudent.Birthday : student.Birthday;
            student.GraduationDate = updatedStudent.GraduationDate != default ? updatedStudent.GraduationDate : student.GraduationDate;
            student.Grade = updatedStudent.Grade != default ? updatedStudent.Grade : student.Grade;

            //write updated student to the text
            string line = student.ToString();
            new StudentFileOperations().Write(line);
            return Ok();
        }

        [HttpPut("{AdminId}/Teachers/{id}")]
        public IActionResult UpdateTeacher(int id,[FromBody] Teacher updatedTeacher)
        {
            var teacher = new TeacherFileOperations().GetTeacherById(updatedTeacher.Id);

            if(teacher is null)
                return BadRequest();

            //delete existing teacher line form text
            string DeletedLine = teacher.ToString();
            new StudentFileOperations().DeleteLine(DeletedLine);

            teacher.Name = updatedTeacher.Name != default ? updatedTeacher.Name: teacher.Name; 
            teacher.Id = updatedTeacher.Id != default ? updatedTeacher.Id : teacher.Id;
            teacher.Email = updatedTeacher.Email != default ? updatedTeacher.Email : teacher.Email;
            teacher.Birthday = updatedTeacher.Birthday != default ? updatedTeacher.Birthday : teacher.Birthday;
            teacher.Subject = updatedTeacher.Subject != default ? updatedTeacher.Subject : teacher.Subject;

            //write updated teacher to the text
            string line = teacher.ToString();
            new TeacherFileOperations().Write(line);
            return Ok();
        }

        [HttpDelete("{AdminId}/Students")]
        public IActionResult DeleteStudents()
        {
            try
            {
               new StudentFileOperations().Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 
            }
            return Ok();
        }

        [HttpDelete("{AdminId}/Teachers")]
        public IActionResult DeleteTeachers()
        {
            try
            {
                new TeacherFileOperations().Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 
            }
            return Ok();
        }

        [HttpDelete("{AdminId}/{id}")] 
        public IActionResult DeleteAdmin(int id)
        {
            //check if the admin is in the admin list
            //if not send bad request 
            List<Admin> admins =new AdminFileOperations().GetAdminList();
            var admin = new AdminFileOperations().GetAdminById(id);
              //if there is not other admin 
            if(admin is null || (admins.Count ==1))
                return BadRequest();
           
            new AdminFileOperations().DeleteLine(admin.ToString());
            return Ok();
        }

        [HttpDelete("{AdminId}/Students/{studentId}")] 
        public IActionResult DeleteStudent(int studentId)
        {
            var student = new StudentFileOperations().GetStudentById(studentId);
            
            if(student is null)
                return BadRequest();
            try
            {
                new StudentFileOperations().DeleteLine(student.ToString());
            }
            catch (System.Exception ex)
            {
                  return BadRequest();   
            }
            return Ok();
        }

        [HttpDelete("{AdminId}/Teachers/{teacherId}")] 
        public IActionResult DeleteTeacher(int teacherId)
        {
            var teacher = new TeacherFileOperations().GetTeacherById(teacherId);
            
            if(teacher is null)
                return BadRequest();
            try
            {
                new TeacherFileOperations().DeleteLine(teacher.ToString());
            }
            catch (System.Exception ex)
            {
                  return BadRequest();
            }
            return Ok();
        }
        
    }
}

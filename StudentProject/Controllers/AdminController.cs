using System;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.FileOperations;

namespace StudentProject.Controllers
{
    [ApiController]
    [Route("[controller]s")]

    public class AdminController : ControllerBase
    {
         private readonly AdminFileOperations _adminContext;
         private readonly StudentFileOperations _studentContext;

        private readonly TeacherFileOperations _teacherContext;


        public AdminController(AdminFileOperations AdminContext,StudentFileOperations StudentContext ,TeacherFileOperations TeacherContext)
        {
            _adminContext = AdminContext;
            _studentContext = StudentContext;
            _teacherContext = TeacherContext;
        }

        //get all admins
        [HttpGet()]
        public List<Admin> GetAdmins()
        {
            List<Admin> admins = _adminContext.GetAdminList();
            return admins;
    
        }

        [HttpGet("{id}")]
        public Admin GetAdmin(int id)
        {
            return _adminContext.GetAdminList().Where(x => x.Id == id).FirstOrDefault();
        }
    

    
        [HttpPost] 

        public IActionResult AddAdmin([FromBody] Admin newAdmin)
        {
            //Check if the admin exists
             List<Admin> admins = _adminContext.GetAdminList();
             var admin = admins.SingleOrDefault(x=>x.Id==newAdmin.Id);
            //If there is a admin with same name
            if(admin is null)
                return BadRequest();

            //If there is not a admin with same name 
            //add admin to admin txt
            _adminContext.Write(admin.ToString());
            return Ok();
        }

        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            List<Student> students = _studentContext.GetStudentList();
             var student = students.SingleOrDefault(x=>x.Id==newStudent.Id);
            
            if(student is null)
                return BadRequest();

            _studentContext.Write(student.ToString());
            return Ok();
        }
        
        public IActionResult AddTeacher([FromBody] Teacher newTeacher)
        {
            List<Teacher> teachers = _teacherContext.GetTeacherList();
            var teacher = teachers.SingleOrDefault(x=>x.Id==newTeacher.Id);
         
            if(teacher is null)
                return BadRequest();

            _teacherContext.Write(teacher.ToString());
            return Ok();
        }

        //put methods to here


        //[HttpDelete] //delete all students admins/{adminId}/students
        [HttpDelete("Students")]
        public IActionResult DeleteStudents()
        {
            try
            {
                _studentContext.Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 throw ex;
            }
            return Ok();
        }


        //[HttpDelete] //delete all teachers  admins/{adminId}/teachers

        [HttpDelete("Teachers")]
        public IActionResult DeleteTeachers()
        {
            try
            {
                _teacherContext.Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 throw ex;
            }
            return Ok();
        }
        [HttpDelete("{adminId}")] // admins/{adminId}
        public IActionResult DeleteAdmin(int adminId)
        {
            //check if the admin is in the admin list
            //if not send bad request 
            List<Admin> admins = _adminContext.GetAdminList();
            var admin = admins.SingleOrDefault(x=>x.Id==adminId);
              //if there is not other admin 
            if(admin is null || (admins.Count ==1))
                return BadRequest();
           
            _adminContext.DeleteLine(admin.ToString());//file oper. could throw ex.
            return Ok();
        }

        [HttpDelete("{studentId}")] //admins/{adminId}/students/{studentId}

        //deleting a student
        public IActionResult DeleteStudent(int studentId)
        {
            
            List<Student> students = _studentContext.GetStudentList();
            var student = students.SingleOrDefault(x=>x.Id==studentId);
            
            if(student is null)
                return BadRequest();
            try
            {
                _studentContext.DeleteLine(student.ToString());
            }
            catch (System.Exception ex)
            {
                  return BadRequest();
                  throw ex;
            }
            return Ok();
        }

        
        [HttpDelete("{teacherId}")]  //admins/{adminId}/teachers/{teacherId}

        //deleting a teacher
        public IActionResult DeleteTeacher(int teacherId)
        {
            List<Teacher> teachers = _teacherContext.GetTeacherList();
            var teacher = teachers.SingleOrDefault(x=>x.Id==teacherId);
            
            if(teacher is null)
                return BadRequest();
            try
            {
                _teacherContext.DeleteLine(teacher.ToString());
            }
            catch (System.Exception ex)
            {
                  return BadRequest();
                  throw ex;
            }
            return Ok();
        }
        
    }
}

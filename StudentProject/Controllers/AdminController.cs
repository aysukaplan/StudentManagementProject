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
        private readonly AdminFileOperations _adminContext;
        private readonly StudentFileOperations _studentContext;

        private readonly TeacherFileOperations _teacherContext;


        public AdminController(AdminFileOperations AdminContext,StudentFileOperations StudentContext ,TeacherFileOperations TeacherContext)
        {
            _adminContext = AdminContext;
            _studentContext = StudentContext;
            _teacherContext = TeacherContext;
        }
        //public AdminController(){}

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
            if(admin is not null)
                return BadRequest();

            //If there is not a admin with same name 
            //add admin to admin txt
            _adminContext.Write(newAdmin.ToString());
            return Ok();
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student newStudent)
        {
            List<Student> students = _studentContext.GetStudentList();
             var student = students.SingleOrDefault(x=>x.Id==newStudent.Id);
            
            if(student is not null)
                return BadRequest();

            _studentContext.Write(newStudent.ToString());
            return Ok();
        }
        [HttpPost]
        public IActionResult AddTeacher([FromBody] Teacher newTeacher)
        {
            List<Teacher> teachers = _teacherContext.GetTeacherList();
            var teacher = teachers.SingleOrDefault(x=>x.Id==newTeacher.Id);
         
            if(teacher is not null)
                return BadRequest();

            _teacherContext.Write(newTeacher.ToString());
            return Ok();
        }

        //put methods to here
        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id,[FromBody] Admin updatedAdmin)
        {
            List<Admin> admins = _adminContext.GetAdminList();
            var admin = admins.SingleOrDefault(x=>x.Id==updatedAdmin.Id);
          
            if(admin is null)
                return BadRequest();

            //delete existing admin line form text
            string DeletedLine = admin.ToString();
            _adminContext.DeleteLine(DeletedLine);

            admin.Name = updatedAdmin.Name != default ? updatedAdmin.Name: admin.Name; //checking if the name is updated or not
            admin.Id = updatedAdmin.Id != default ? updatedAdmin.Id : admin.Id;
            admin.Email = updatedAdmin.Email != default ? updatedAdmin.Email : admin.Email;
            admin.Birthday = updatedAdmin.Birthday != default ? updatedAdmin.Birthday : admin.Birthday;
            //write updated admin to the text
            string line = admin.ToString();
            _adminContext.Write(line);
            return Ok();
        }
         [HttpPut("{AdminId}/Students/{id}")]
        public IActionResult UpdateStudent(int id,[FromBody] Student updatedStudent)
        {
            List<Student> students = _studentContext.GetStudentList();
             var student = students.SingleOrDefault(x=>x.Id==updatedStudent.Id);
          
            if(student is null)
                return BadRequest();

            //delete existing student line form text
            string DeletedLine = student.ToString();
            _studentContext.DeleteLine(DeletedLine);

            student.Name = updatedStudent.Name != default ? updatedStudent.Name: student.Name; 
            student.Id = updatedStudent.Id != default ? updatedStudent.Id : student.Id;
            student.Email = updatedStudent.Email != default ? updatedStudent.Email : student.Email;
            student.Birthday = updatedStudent.Birthday != default ? updatedStudent.Birthday : student.Birthday;
            student.GraduationDate = updatedStudent.GraduationDate != default ? updatedStudent.GraduationDate : student.GraduationDate;
            student.Grade = updatedStudent.Grade != default ? updatedStudent.Grade : student.Grade;
            //write updated student to the text
            string line = student.ToString();
            _studentContext.Write(line);
            return Ok();
        }
         [HttpPut("{AdminId}/Teachers/{id}")]
        public IActionResult UpdateTeacher(int id,[FromBody] Teacher updatedTeacher)
        {
            List<Teacher> teachers = _teacherContext.GetTeacherList();
            var teacher = teachers.SingleOrDefault(x=>x.Id==updatedTeacher.Id);
            if(teacher is null)
                return BadRequest();

            //delete existing teacher line form text
            string DeletedLine = teacher.ToString();
            _studentContext.DeleteLine(DeletedLine);

            teacher.Name = updatedTeacher.Name != default ? updatedTeacher.Name: teacher.Name; 
            teacher.Id = updatedTeacher.Id != default ? updatedTeacher.Id : teacher.Id;
            teacher.Email = updatedTeacher.Email != default ? updatedTeacher.Email : teacher.Email;
            teacher.Birthday = updatedTeacher.Birthday != default ? updatedTeacher.Birthday : teacher.Birthday;
            teacher.Subject = updatedTeacher.Subject != default ? updatedTeacher.Subject : teacher.Subject;
            //write updated teacher to the text
            string line = teacher.ToString();
            _teacherContext.Write(line);
            return Ok();
        }



        //[HttpDelete] //delete all students admins/{adminId}/students
        [HttpDelete("{AdminId}/Students")]
        public IActionResult DeleteStudents()
        {
            try
            {
                _studentContext.Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 
            }
            return Ok();
        }


        //[HttpDelete] //delete all teachers  admins/{adminId}/teachers

        [HttpDelete("{AdminId}/Teachers")]
        public IActionResult DeleteTeachers()
        {
            try
            {
                _teacherContext.Clear();
            }
            catch (System.Exception ex)
            {
                 return BadRequest();
                 
            }
            return Ok();
        }
        [HttpDelete("{AdminId}/{id}")] // admins/{adminId}
        public IActionResult DeleteAdmin(int id)
        {
            //check if the admin is in the admin list
            //if not send bad request 
            List<Admin> admins = _adminContext.GetAdminList();
            var admin = admins.SingleOrDefault(x=>x.Id==id);
              //if there is not other admin 
            if(admin is null || (admins.Count ==1))
                return BadRequest();
           
            _adminContext.DeleteLine(admin.ToString());//file oper. could throw ex.
            return Ok();
        }

        [HttpDelete("{AdminId}/Students/{studentId}")] //admins/{adminId}/students/{studentId}

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
                
            }
            return Ok();
        }

        
        [HttpDelete("{AdminId}/Teachers/{teacherId}")]  //admins/{adminId}/teachers/{teacherId}

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
                
            }
            return Ok();
        }
        
    }
}

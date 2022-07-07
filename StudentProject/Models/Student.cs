using System;
namespace StudentProject.Models;

public class Student
{
    public Student(string name, int id, string email, string birthday, string graduationDate)
    {
        Name = name;
        Id = id;
        Email = email;
        Birthday = birthday;
        GraduationDate = graduationDate;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public string Email  { get; set; }
    public string Birthday { get; set; }
    public string GraduationDate { get; set; }

    public DateTime CreateDate;
    public DateTime UpdateDate;
}

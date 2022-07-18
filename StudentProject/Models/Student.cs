using System;


namespace StudentProject.Models;


public class Student : Person
{
    
    public string GraduationDate { get; set; }
    public int Grade { get; set; }

    public Student(string name, int id, string email, string birthday, string graduationDate, int grade )
        :base(name, id, email, birthday)
    {
        GraduationDate = graduationDate;
        Grade = grade;
    }
    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3},{4},{5}", Name, Id, Email, Birthday,GraduationDate,Grade);
    }
}

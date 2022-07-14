﻿using System;


namespace StudentProject.Models;


public class Student : Person
{
    
    public string GraduationDate { get; set; }
    public int Id { get; set; }
    public int Grade { get; set; }

    public Student(string name, string email, string birthday, string graduationDate, int id, int grade )
        :base(name, email, birthday)
    {
        GraduationDate = graduationDate;
        Id = id;
        Grade = grade;
    }
}

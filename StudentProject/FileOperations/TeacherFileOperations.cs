using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public class TeacherFileOperations :  FileOperations
{
    public string FileName = "teacher.txt";

    public override void Read()
    {

    }

    public override void Write()
    {

    }

    public override void Clear()
    {

    }

    public override List<Person> GetList()
    {
        //Downcasting inside the method
        return new List<Person>();
    }
}



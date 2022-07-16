using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public class StudentFileOperations : FileOperations
{
    public readonly string  FileName = "student.txt";

    public override void Read()
    {

    }

    public override void Write()
    {

    }

    public override void Clear()
    {

    }

    public override List<Person>  GetList()
    {
       return new List<Person>();
    }
}

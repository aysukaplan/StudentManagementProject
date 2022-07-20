using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public class StudentFileOperations : IFileOperations
{
    private string _filePath = "Datas/student.txt";

    public void Write(string line)
    {
    
        string[] readText = File.ReadAllLines(_filePath);
        readText = readText.Concat(new string[] { line }).ToArray();
        File.WriteAllText(_filePath,String.Empty);
        File.AppendAllLines(_filePath,readText);
    }

    public void Clear()
    {
        FileStream fileStream = File.Open(_filePath, FileMode.Open);
        fileStream.SetLength(0);
        fileStream.Close();
    }
    public void DeleteLine(string line){
        // 1. Read the content of the file
        string[] readText = File.ReadAllLines(_filePath);

        // 2. Empty the file
        File.WriteAllText(_filePath, String.Empty);

        // 3. Fill up again, but without the deleted line
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            foreach (string s in readText)
            {
                if (!s.Equals(line))
                {
                    writer.WriteLine(s);
                }
            }
        }
    }
    
    public List<Student> GetStudentList()
    {
        //eğer dosya boştaysa??
        List<Student> StudentList = new List<Student>();
        // reads lines from text and adds the lines string array
        string[] _lines = {};
        try
        {
            _lines = File.ReadAllLines(_filePath);

        }
        catch (Exception e)
        {
            throw  e;
        }
        foreach (var line in _lines)
        {
            string[] lineSplit = line.Split(",");
            var student = new Student(lineSplit[0],int.Parse(lineSplit[1]),lineSplit[2],
                lineSplit[3],lineSplit[4],int.Parse(lineSplit[5]));
            StudentList.Add(student);
        }
        return StudentList;
    }
}

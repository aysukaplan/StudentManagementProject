using System.Data.Common;
using System.IO;

namespace StudentProject.Models;

public class StudentContext
{
    // reads lines from text and adds the lines string array

    /*
    private string[] _lines = {};


    private bool _firstList = true;
    public List<Student> StudentList = new List<Student>();

    //burası ayrıştırılacak
    public void LinesToStudentList(){
        try
        {
            _lines = File.ReadAllLines(
                "C:/Users/Asus/Documents/myCodes/Project/StudentProject/Datas/students.txt"); //hata alıyor mu?

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }
        foreach (var line in _lines)
        {
            string[] lineSplit = line.Split(",");
            var Student = new Student(lineSplit[0],lineSplit[1],lineSplit[2],
                lineSplit[3], int.Parse(lineSplit[4]), int.Parse(lineSplit[5]));
            StudentList.Add(Student);
        }
    }

    public List<Student>GetStudents(){
        if(_firstList){
            LinesToStudentList();
            _firstList = false;
        }
        return StudentList;
    }
    public void SetStudents(List<Student> students){
        StudentList = students;
    }
    */
}




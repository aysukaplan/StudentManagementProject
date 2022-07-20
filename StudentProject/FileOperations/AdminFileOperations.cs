using System.Linq.Expressions;
using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public class AdminFileOperations : IFileOperations
{
    private string _filePath = "Datas/admin.txt";




    public void Write(string line)
    {
        StreamWriter writer = new StreamWriter(_filePath, true);
        var s = writer.NewLine;
        writer.Write(line);
        writer.Close();
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
                if (!s.Equals(line) && !s.Equals("")) 
                {
                    writer.WriteLine(s);
                }
            }
        }
    }
    public List<Admin> GetAdminList()
    {
        List<Admin> AdminList = new List<Admin>();
        // reads lines from text and adds the lines string array
        
        string[] _lines = {};
        
        _lines = File.ReadAllLines(_filePath);

        foreach (var line in _lines)
        {
            string[] lineSplit = line.Split(",");
            var admin = new Admin(lineSplit[0],int.Parse(lineSplit[1]),lineSplit[2], lineSplit[3]);
            AdminList.Add(admin);
        }
        return AdminList;
    }
}
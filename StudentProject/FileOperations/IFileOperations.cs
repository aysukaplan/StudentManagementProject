using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public interface IFileOperations
{
    void Read();
    void Write();
    void Clear();
    List<Person> GetList();

}

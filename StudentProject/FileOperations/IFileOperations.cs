using System;
using StudentProject.Models;
using System.IO;

namespace StudentProject.FileOperations;

public interface IFileOperations
{

    
    void Write(string line);
    void Clear();
    void DeleteLine(string line);
}

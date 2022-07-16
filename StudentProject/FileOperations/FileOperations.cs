using System;

namespace StudentProject.FileOperations;

public abstract class FileOperations
{
    

    public abstract void Read();
    public abstract void Write();
    public abstract void Clear();
    public abstract List<Person> GetList();

}

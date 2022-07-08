namespace StudentProject.Models;

public class Teacher : Person
{
    public string  Subject { get; set; }

    public Teacher(string name, string email, string birthday, DateTime createDate, DateTime updateDate, string subject)
    :base(name, email, birthday, createDate, updateDate)
    {
        Subject = subject;
    }
}
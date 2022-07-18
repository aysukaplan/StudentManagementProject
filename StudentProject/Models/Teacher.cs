namespace StudentProject.Models;

public class Teacher : Person
{
    public string  Subject { get; set; }

    public Teacher():base(){}

    public Teacher(string name,int id, string email, string birthday, string subject)
    :base(name, id, email, birthday)
    {
        Subject = subject;
    }
    public Teacher(string name,int id, string email, string birthday, string subject, DateTime createDate, DateTime updateDate)
    :base(name, id, email, birthday, createDate, updateDate)
    {
        Subject = subject;
    }
    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3},{4}", Name, Id, Email, Birthday,Subject);
    }
  
}
namespace StudentProject.Models;

public class Admin : Person
{
    public int AdminId { get; set; }

    public Admin(string name, string email, string birthday, DateTime createDate, DateTime updateDate, int adminId)
        :base(name, email, birthday, createDate, updateDate)
    {
        AdminId = adminId;
    }
}
namespace StudentProject.Models;

public class Admin : Person
{
   
    public Admin():base(){}
    public Admin(string name, int Id,string email, string birthday, DateTime createDate, DateTime updateDate)
        :base(name, Id, email, birthday, createDate, updateDate)
    {    
    }
     public Admin(string name, int Id,string email, string birthday)
        :base(name, Id, email, birthday)
    {    
    }
    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3}", Name, Id, Email, Birthday);
    }
}
using System;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Birthday { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
   
    
    public Person(string name, string email, string birthday, DateTime createDate, DateTime updateDate)
    {
        Name = name;
        Email = email;
        Birthday = birthday;
        CreateDate = createDate;
        UpdateDate = updateDate;
    }
    public Person(string name, string email, string birthday)
    {
        Name = name;
        Email = email;
        Birthday = birthday;
    }


}

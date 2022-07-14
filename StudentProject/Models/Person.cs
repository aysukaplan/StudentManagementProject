using System;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Birthday { get; set; }
   
    //asagıdaki doğru mu? null kısmı
    //Date leri farklı bir classta mı saklasam?
    public DateTime CreateDate;
    public DateTime UpdateDate;

    
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

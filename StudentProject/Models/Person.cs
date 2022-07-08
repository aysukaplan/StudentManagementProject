using System;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Birthday { get; set; }
   
    //asagıdaki doğru mu? null kısmı
    //Date leri farklı bir classta mı saklasam?
    public DateTime CreateDate = null;
    public DateTime UpdateDate = null;

    public Person()
    {
        
    }

    public Person(string name, string email, string birthday, DateTime createDate, DateTime updateDate)
    {
        Name = name;
        Email = email;
        Birthday = birthday;
        CreateDate = createDate;
        UpdateDate = updateDate;
    }
}

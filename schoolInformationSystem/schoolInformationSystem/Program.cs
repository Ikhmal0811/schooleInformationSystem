using System;

public class Person
{
    private string name;
    private int age;
    private string id;

    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public int Age
    {
        get {return age;}
        set
        {
            if(value<=0)
                Console.WriteLine("Age cannot be negative");
            else
                age = value;
        }
    }

    public string Id
    {
        get{return id;}
        set{id = value;}
    }
        
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Muiz";
        Console.WriteLine(p.Name);
    }
        
}
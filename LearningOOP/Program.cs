using System;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Jino Lupango"; //set siya value
        person.Age = 25;
        Console.WriteLine("Hello, " + person.Name + "!");
        Console.WriteLine("Your are, " + person.Age + " Years Old!");
    }
}
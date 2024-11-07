// See https://aka.ms/new-console-template for more information
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        string name = "kira";
        int age = 25;

        Person person = new Person();
        person.Name = name;
        person.Age = age;

        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");

        person.Name = "lui";
        person.Age = 30;

        Console.WriteLine($"Updated Name: {person.Name}");
        Console.WriteLine($"Updated Age: {person.Age}");
    }
}

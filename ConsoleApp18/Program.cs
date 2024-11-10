//// See https://aka.ms/new-console-template for more information
//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//public class Program
//{
//    static void Main(string[] args)
//    {
//        string name = "kira";
//        int age = 25;

//        Person person = new Person();
//        person.Name = name;
//        person.Age = age;

//        Console.WriteLine($"Name: {person.Name}");
//        Console.WriteLine($"Age: {person.Age}");

//        person.Name = "lui";
//        person.Age = 30;

//        Console.WriteLine($"Updated Name: {person.Name}");
//        Console.WriteLine($"Updated Age: {person.Age}");
//    }
//}
public class Person
{
    public string? Name { get; set; }     // გახდა nullable
    public int Age { get; set; }

    public void ChangeNameAndAge(string newName, int newAge)
    {
        Name = newName;
        Age = newAge;
    }

    public void PrintPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "kira";
        person1.Age = 25;
        Person person2 = person1;
        person2.ChangeNameAndAge("lui", 30);
        person1.PrintPersonInfo();
        person2.PrintPersonInfo();
    }
}
using System;

// Person1 shows the classic or old-style approach:
// keep fields private and expose behavior through methods.
public class Person1
{
    private string _name;
    private int _age;

    //setters
    public void Setter(string name, int age)
    {
        _name = name;
        _age = age;
    }

    //getters
    public string GetName() => _name;
    public int GetAge() => _age;
}

// Person2 uses the modern C# approach:
// properties are the common way to encapsulate data.
public class Person2
{
    private string _name;
    private int _age;

    // The constructor initializes the object when it is created.
    public Person2(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Name is a Property
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Age is a Property
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

// Person3 shows a modern encapsulation pattern:
// public read access with private setters.
public class Person3
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    
    public Person3(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Main
public class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        p1.Setter("Person1", 19);

        Person2 p2 = new Person2("Person2", 19);

        Person3 p3 = new Person3("Person3", 19);

        Console.WriteLine($"Name: {p1.GetName()}, Age: {p1.GetAge()}");
        Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");
        Console.WriteLine($"Name: {p3.Name}, Age: {p3.Age}");

        Console.ReadKey();
    }
}
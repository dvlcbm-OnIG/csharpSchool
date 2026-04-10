using System;

class Student
{
    // Private field
    private string name;
    private int age;
    private double salary;

    //Setter
    public void Setter(string n, int a, double s)
    {
        name = n;
        age = a;
        salary = s;
    }
    //Getter (return function) to access the private
    public string GetName()
    {
        return name;        // gets the value of 'name' and returns it to the caller when the function is called.
    }
    public int GetAge()
    {
        return age;        // gets the value of 'age' and returns it to the caller when the function is called.
    }
    public double GetSalary()
    {
        return salary;     // gets the value of 'salary' and returns it to the caller when the function is called.
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.Setter("Russel", 18, 859283.53);
        // Get value - the CALLER
        Console.WriteLine(s.GetName());
        Console.WriteLine(s.GetAge());
        Console.WriteLine(s.GetSalary());

        Console.ReadKey();
    }
}
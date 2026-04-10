using System;

class Student
{
    // Private field
    private string name = "Russel jeoff";
    private int age = 18;
    private double salary = 3987494.43;


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

        // Get value - the CALLER
        Console.WriteLine(s.GetName());
        Console.WriteLine(s.GetAge());
        Console.WriteLine(s.GetSalary());

        Console.ReadKey();
    }
}
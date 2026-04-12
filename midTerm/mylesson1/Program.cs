using System;

//#1
public class Student
{
    public string name = "speed";
    public string course = "BSIT";

    public void DisplayStudent()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Course: {course}");
    }
}
public class GradedStudent : Student
{
    public double midTerm = 90.43;
    public double finalExam = 92.53;
    
    public void ComputeAverage()
    {
        DisplayStudent();

        double Average = (midTerm + finalExam) / 2;
        Console.WriteLine($"Average: {Average}");
    }
}







public class Program
{
    public static void Main(string[] args)
    {
        GradedStudent gStudent = new GradedStudent();

  
        gStudent.ComputeAverage();


        Console.ReadLine();
    }
}

using System;

//#1
public class Student
{
    public string name = "speed";
    public string course = "bscs";

    public void DisplayStudent()
    {
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Student course: {course}");
    }
}

public class GradedStudent : Student
{
    public double midTerm = 75;
    public double finalExam = 80;

    public void ComputeAverage()
    {
        double Average = (midTerm + finalExam) / 2;
        DisplayStudent();
        Console.WriteLine($"Average: {Average}");
    }
}

//#2
public class Worker
{
    public string name = "kai";
    public double basicSalary = 67676.54;

    public void DisplayWorker()
    {
        Console.WriteLine($"Worker's name: {name}");
        Console.WriteLine($"Salary: {basicSalary}");
    }
}
public class BonusEmployee : Worker
{
    public double bonusRate = 54.6;

    public void ComputeTotalSalary()
    {
       double Bonus = basicSalary * bonusRate / 100;
        DisplayWorker();
        Console.WriteLine($"Bonus: {Bonus}");
    }
}




public class Program
{
    public static void Main(string[] args)
    {
        //create an object        
        GradedStudent gdStd = new GradedStudent();
        BonusEmployee bEmp = new BonusEmployee();


        //call the method from the class
        Console.WriteLine("======= 1 ======");
        gdStd.ComputeAverage();
        Console.WriteLine("======= 2 ======");
        bEmp.ComputeTotalSalary();
        Console.WriteLine("======= 3 ======");




        Console.ReadLine();

    }
}

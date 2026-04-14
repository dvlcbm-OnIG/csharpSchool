//1
using System;

public class Person
{
    public string name = "Stranger";
    public int age = 20;

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }
}
public class Employee : Person
{
    public double hoursWorked = 8;
    public double hourlyRate = 2533.87;

    public void ComputeSalary()
    {
        double Salary = hourlyRate * hoursWorked;

        DisplayPerson();
        Console.WriteLine($"Salary: {Salary}");
    }
}

//2
public class Product
{
    public string ProductName = "Dumbell";
    public double Price = 755.75;

    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
    }
}
public class DiscountedProduct : Product
{
    public double DiscountedPercent = 0.4;

    public void ComputeDiscountedPrice()
    {
        double FinalPrice = Price - (Price * DiscountedPercent / 100);

        DisplayProduct();
        Console.WriteLine($"Final Price: {FinalPrice}");
    }
}

//3




//Main
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        DiscountedProduct dProd = new DiscountedProduct();

        emp.ComputeSalary();
        dProd.ComputeDiscountedPrice();


        Console.ReadKey();
    }
}
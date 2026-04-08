

using System;
using System.Security.Cryptography.X509Certificates;


//#1
public class ElectronicDevice
{
    public string Brand = "Samsung";
    public string Model = "S24";
    public double Price = 999.99;
    public bool IsWaterproof = true;
    public int WarrantyMonths = 24;

}
public class Smartphone : ElectronicDevice
{
 public void Introduce()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Waterproff: {IsWaterproof}");
        Console.WriteLine($"Warranty: {WarrantyMonths} months");

    }
}


//#2
public class Account
{
    public int AccountNumber = 12345;
    public string AccountHolder = "John Doe";
    public double Balance = 5000.0;
    public string BranchCode = "NY001";
    public double InterestRate = 0.05;

}

public class SavingsAccount : Account
{
    public void Introduce()
    {
        Console.WriteLine($"Balance: ${Balance}");

    }
}


//#3
public class Animal
{

    public string Species = "Canine";
    public int Age = 5;
    public double Weight = 20.5;
    public string Color = "Brown";
    public string Habitat = "Domestic";

    public virtual void MakeSound()
    {
        Console.WriteLine("Generic Sound");
    }

}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

//#4
public sealed class FinalReport
{
    public int ReportID = 101;
    public string Title = "Annual Summary";
    public string Author = "Admin";
    public int PageCount = 50;
    public bool IsApproved = true;
}
/*
public class DetailedReport : FinalReport //error. cannot acces sealed class
{
    
}
I do not really know the real reason why sealed doesn't let inheritance,
    but based on my analysis, it is already self-explanatory. From the word
itself sealed, means it cannot be touched or access.
*/

//#5
public class SchoolMember
{
   public string Name = "Unknown";
   public int SchoolID = 0;
   public string Email = "school@edu.com";
   public string JoinDate = "2024-01-01";
   public string Campus = "Main";
}



public class Student : SchoolMember
{
    public void Introduce()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"School Id: {SchoolID}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Join Date: {JoinDate}");
        Console.WriteLine($"Campus: {Campus}");

    }
}
//#6
class Vehicle
{
    public int Wheels;
}

class Car : Vehicle
{
    public void SetWheels()
    {
        Wheels = 4;
    }
}

class Motorcycle : Vehicle
{
    public void SetWheels()
    {
        Wheels = 2;
    }
}

class Bus : Vehicle
{
    public void SetWheels()
    {
        Wheels = 6;
    }
}

//#7
public class Teacher : SchoolMember
{
    public double Salary = 50000.0;

    public void Introduce()
    {
        double NewSalary = Salary + (Salary * 0.12);
        Console.WriteLine($"NewSalary: {NewSalary}");
    }
}
//8
public class Student2
{
    public string Name = "IshowSpeed";
    public int Age = 20;
    public string Address = "Ohio";
    public char Section = 'D';
    public double Gpa = 3.2;

    public void Introduce()
    {
        
        if(Gpa > 3.0)
        {
            double bonus = Gpa + 0.5;
            Console.WriteLine($"Final GPA: {bonus}. With bonus");
        }
        else
        {
            Console.WriteLine($"Final GPA: {Gpa}. No bonus");
        }
    }
}

//9
public class Teacher2
{
    public string Name = "Tony";
    public int Age = 50;
    public string Subject = "Physics";
    public double Salary = 50000.0;
    public double SuppliesBudget = 1500.0;
}
public class Child : Teacher2 
{ 
    public void Introduce()
    {
        double totalBudget = 5 * (Salary + SuppliesBudget);

        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"Salary: ${Salary}");
        Console.WriteLine($"Supplies Budget: ${SuppliesBudget}");
        Console.WriteLine($"Total cost for 5 teachers: ${totalBudget}");
    }
}
//10
class Vehicle2
{
    public string Brand = "Toyota";
}

class Bus2 : Vehicle2
{
    public int PassengerCapacity = 60;   
    public int CurrentPassengers = 25;   
    public string Route = "Skyway";   
    public string DriverName = "Tony";   
    public int BusNumber = 67;      

    public void GetRemainingSeats()
    {
       int remainingSeats = PassengerCapacity - CurrentPassengers;
        Console.WriteLine($"Remaining Seats: {remainingSeats}");

    }
}

public class Program
{
    public static void CalculateTotalWheels()
    {
        int totalCars = 3;
        int totalMotorcycles = 4;
        int totalBuses = 2;

        Car car = new Car();
        Motorcycle moto = new Motorcycle();
        Bus bus = new Bus();

        car.SetWheels();
        moto.SetWheels();
        bus.SetWheels();

        int totalWheels = (totalCars * car.Wheels) + (totalMotorcycles * moto.Wheels) + (totalBuses * bus.Wheels);

        Console.WriteLine($"Total Wheels: {totalWheels}");
    }


    public static void Main(string[] args)
    {
        Smartphone sPhone = new Smartphone(); //1
        SavingsAccount sAccount = new SavingsAccount(); //2
        Dog dog = new Dog(); //3
        Student student = new Student(); //5
        Teacher teacher = new Teacher(); //7
        Student2 student2 = new Student2(); //8
        Child child = new Child(); //9
        Bus2 bus2 = new Bus2();

        //1
        Console.WriteLine("==========1=========");
        sPhone.Introduce();
        Console.WriteLine();
        Console.WriteLine();

        //2
        Console.WriteLine("==========2=========");
        sAccount.Introduce();
        Console.WriteLine();
        Console.WriteLine();

        //3
        Console.WriteLine("==========3=========");
        dog.MakeSound();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("==========4=========");
        Console.WriteLine("#4 is sealed class");
        Console.WriteLine();

        //5
        Console.WriteLine("==========5=========");
        student.Introduce();
        Console.WriteLine();
        Console.WriteLine();

        //6
        Console.WriteLine("==========6=========");
        CalculateTotalWheels();
        Console.WriteLine();
        Console.WriteLine();

        //7
        Console.WriteLine("==========7=========");
        teacher.Introduce();
        Console.WriteLine();
        Console.WriteLine();


        //8
        Console.WriteLine("==========8=========");
        student2.Introduce();
        Console.WriteLine();
        Console.WriteLine();

        //9
        Console.WriteLine("==========9=========");
        child.Introduce();
        Console.WriteLine();
        Console.WriteLine();

        //10
        Console.WriteLine("==========10=========");
        bus2.GetRemainingSeats();
        
        Console.ReadKey();
    }
}
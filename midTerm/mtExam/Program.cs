//Date finished: 04-14-26

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
        Console.WriteLine($"Salary: {Salary:C}");
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
        Console.WriteLine($"Price: {Price:C}");
    }
}
public class DiscountedProduct : Product
{
    public double DiscountedPercent = 0.4;

    public void ComputeDiscountedPrice()
    {
        double FinalPrice = Price - (Price * DiscountedPercent / 100);

        DisplayProduct();
        Console.WriteLine($"Final Price: {FinalPrice:C}");
    }
}

//3
public class BankAccount
{
    public string AccountName = "Glimpse of You";
    public double Balance = 041026.00;
    
    public void Deposit(double amount)
    {
        Console.WriteLine($"Deposit: {amount}");
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"Account Name: {AccountName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}
public class SavingsAccount : BankAccount
{
    public double InterestRate = 0.67;

    public void ComputeInterest()
    {
        double Interest = Balance * InterestRate / 100;
        double NewBalance = Balance + Interest;

        DisplayBalance();
        Deposit(0);
        Console.WriteLine($"Interest: {Interest}");
        Console.WriteLine($"New Balance: {NewBalance:C}");
    }
}

//4
public class Customer
{
    public string Name = "Stranger";

    public void DisplayCustomer()
    {
        Console.WriteLine($"Name: {Name}");
    }

}
public class ElectricBill : Customer
{
    public int UnitsConsumed = 10;
    public double RatePerUnit = 0.54;

    public void ComputedBill()
    {
        double Bill = UnitsConsumed * RatePerUnit;

        Console.WriteLine($"Bill: {Bill:C}");
    }
}

//5
public class Vehicle
{
    public string VehicleName = "Motorcycle";

    public void DisplayVehicle()
    {
        Console.WriteLine($"Vehicle Name: {VehicleName}");
    }

}
public class FuelVehicle : Vehicle
{
    public double Distance = 20.5;
    public double FuelEfficiency = 15.59;
    public double FuelPrice = 135.15;

    public void ComputedFuelCost()
    {
        double FuelUsed = Distance / FuelEfficiency;
        double TotalCost = FuelUsed * FuelPrice;

        Console.WriteLine($"Total Fuel Cost: {TotalCost:C}");
    }
}


//Main
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        DiscountedProduct dProd = new DiscountedProduct();
        SavingsAccount sAcc = new SavingsAccount();
        ElectricBill eBill = new ElectricBill();
        FuelVehicle fVehicle = new FuelVehicle();

        Console.WriteLine("============ 1 =============");
        emp.ComputeSalary();
        Console.WriteLine("============ 2 =============");
        dProd.ComputeDiscountedPrice();
        Console.WriteLine("============ 3 =============");
        sAcc.ComputeInterest();
        Console.WriteLine("============ 4 =============");
        eBill.ComputedBill();
        Console.WriteLine("============ 5 =============");
        fVehicle.ComputedFuelCost();
        Console.ReadKey();
    }
}
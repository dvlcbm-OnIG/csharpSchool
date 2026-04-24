using System;

// 1. Circle
public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value > 0)
                _radius = value;
        }
    }

    public double Area
    {
        get { return 3.14 * _radius * _radius; }
    }
}

// 2. Step Counter
public class StepCounter
{
    private int _steps;

    public StepCounter()
    {
        _steps = 0;
    }

    public int Steps
    {
        get { return _steps; }
        set
        {
            if (value > _steps)
                _steps = value;
        }
    }

    public double DistanceInKm
    {
        get { return _steps * 0.0008; }
    }
}

// 3. Rectangle
public class Rectangle
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        Length = length;  
        Width = width;    
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public double Area
    {
        get { return _length * _width; }
    }
}

// 4. Car Speedometer
public class Car
{
    private int _speed;

    public Car()
    {
        _speed = 0;
    }

    public int Speed
    {
        get { return _speed; }
        set
        {
            if (value >= 0 && value <= 200)
                _speed = value;
        }
    }
}

// 5. Product Price
public class Product
{
    private double _price;

    public Product(double price)
    {
        Price = price;
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
                _price = value;
        }
    }

    public double TaxedPrice
    {
        get { return _price * 1.12; }
    }
}

// 6. Student Grade
public class Student
{
    private int _grade;

    public Student(int grade)
    {
        Grade = grade;
    }

    public int Grade
    {
        get { return _grade; }
        set
        {
            if (value >= 0 && value <= 100)
                _grade = value;
        }
    }
}

// 7. Bank Account
public class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    public double Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
                _balance = value;
        }
    }
}

// 8. Temperature Converter
public class Temperature
{
    private double _celsius;

    public Temperature(double celsius)
    {
        Celsius = celsius;  
    }

    public double Celsius
    {
        get { return _celsius; }
        set { _celsius = value; }
    }

    public double Fahrenheit
    {
        get { return (_celsius * 1.8) + 32; }
    }
}

// 9. Employee Name
public class Employee
{
    private string _name;

    public Employee(string name)
    {
        Name = name;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            _name = value == null || value == "" ? "Unknown" : value;
        }
    }
}

// 10. Water Tank
public class WaterTank
{
    private double _liters;

    public WaterTank(double liters)
    {
        Liters = liters;
    }

    public double Liters
    {
        get { return _liters; }
        set
        {
            _liters = value > 500 ? 500 : value;
        }
    }
}

//main
public class Program
{
   public static void Main()
    {
       
        Circle c = new Circle(5);
        StepCounter s = new StepCounter();
        Rectangle r = new Rectangle(4, 6);
        Car car = new Car();
        Product p = new Product(100);
        Student st = new Student(90);
        BankAccount acc = new BankAccount(500);
        Temperature t = new Temperature(25);
        Employee e = new Employee("");
        WaterTank tank = new WaterTank(600);


        s.Steps = 1500;
        car.Speed = 180;

        
        Console.WriteLine($"1.) Circle Area: {c.Area}");
        Console.WriteLine($"2.) Steps: {s.Steps}, Distance: {s.DistanceInKm} km");
        Console.WriteLine($"3.) Rectangle Area: {r.Area}");
        Console.WriteLine($"4.) Car Speed: {car.Speed}");
        Console.WriteLine($"5.) Taxed Price: {p.TaxedPrice}");
        Console.WriteLine($"6.) Student Grade: {st.Grade}");
        Console.WriteLine($"7.) Balance: {acc.Balance}");
        Console.WriteLine($"8.) Fahrenheit: {t.Fahrenheit}");
        Console.WriteLine($"9.) Employee Name: {e.Name}");
        Console.WriteLine($"10.) Water Level: {tank.Liters} liters");

        Console.ReadKey();
    }
}
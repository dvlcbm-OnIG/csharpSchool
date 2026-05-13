//for testing
using System;
using System.Runtime.InteropServices;
//1
public class Circle
{
    private double _radius;
    
    //constructor
    public Circle(double r)
    {
        Radius = r;
    }
    //property-1 (modifiable)
    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value > 0)
            {
                _radius = value;
            }
        }
    }
    //property-2 (read-only)
    public double Area
    {
        get { return 3.14 * (_radius * _radius); }

        //it becomes read-only because there is no setter
    }
}
//2
public class StepCounter
{
    private int _steps;
    public StepCounter()
    {
        _steps = 0;
    }
    public int Steps
    {
       get { return _steps;  }
        set
        {
            if (value > _steps)
            {
                _steps = value;
            }
        }
    }
    public double DistanceInKm
    {
        get { return _steps * 0.0008; }
    }
}

//3
public class ProductPrice
{
    private double _price;
    public ProductPrice (double p)
    {
        Price = p;
    }
    public double Price
    {
        get { return _price;  }
        set
        {
            if (value >=0)
            {
                _price = value;
            }
        }
    }
    public double TaxedPrice
    {
        get { return _price * 1.12;  }
    }
}
//4
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
            if (value == null || value == "")
            {
                _name = "Unknown";
            }
            else
            {
                _name = value;
            }
        }
    }
}
public class Program
{
    public static void Main()
    {
        //1
    Circle circ = new Circle(10.2);//can only put value inside object when it has constructor

        Console.WriteLine(circ.Radius);
        //2
        StepCounter sCon = new StepCounter();

        sCon.Steps = 10;
        Console.WriteLine($"{sCon.Steps}, {sCon.DistanceInKm}");
        //3
        ProductPrice pPrice = new ProductPrice(12);
        Console.WriteLine(pPrice.Price + ", " + pPrice.TaxedPrice);

        //4
        Employee emp = new Employee("");
        Console.WriteLine(emp.Name);
        Console.ReadKey();
    } 
}

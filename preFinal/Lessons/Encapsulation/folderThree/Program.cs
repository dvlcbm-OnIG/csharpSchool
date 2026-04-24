using System;

public class Person
{
    private double radius;

    public void Setter(double RADIUS)
    {
        if (RADIUS > 0)
        {
            radius = RADIUS;
        }
    }


    public double getRadius()
    {
        return radius;
    }

    public double getArea()
    {
        return 3.1416 * (radius * radius);
    }
   

}

public class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Setter(10.43);

        Console.WriteLine($"Area: {p.getArea()}");
 


        Console.ReadKey();
    }
}


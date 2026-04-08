using System;


public static class Program
{
    public static double Cube(double a) => ( a * a * a);
    public static double RectangularPrism(double l, double w, double h) => (l * w * h);
    public static double Cylinder(double r, double h) => 2 * Math.PI * (r + h);
    public static double Cone(double r, double l) => Math.PI * (r + l);
    public static double Sphere(double r) => 4 * Math.PI * (r * r);
    public static double Hemisphere(double r) => 3 * Math.PI * (r * r);

    public static void Main(string[] args)
    {

        Console.WriteLine(Cube(3));
        Console.WriteLine(RectangularPrism(10, 20, 25));
        Console.WriteLine(Cylinder(3, 6));
        Console.WriteLine(Cone(2, 4));
        Console.WriteLine(Sphere(3));
        Console.WriteLine(Hemisphere(2));

        
        Console.ReadKey();

    }
}
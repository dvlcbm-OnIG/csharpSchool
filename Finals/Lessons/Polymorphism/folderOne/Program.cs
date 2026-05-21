using System;

// Polymorphism means one method name can do different jobs depending on the input.
// It applies to the Add methods below and the calls in Main().
class MathOperations
{
    // Add for two int numbers.
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add for two double numbers.
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Add for three int numbers.
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        // Create the MathOperations object.
        MathOperations math = new MathOperations();

        // Calls the int version.
        Console.WriteLine(math.Add(2, 3));

        // Calls the double version.
        Console.WriteLine(math.Add(2.5, 3.5));

        // Calls the three-number version.
        Console.WriteLine(math.Add(1, 2, 3));
    }

    //Output:
     //  5
     //  6
     //  6
}
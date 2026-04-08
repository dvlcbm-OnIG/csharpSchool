
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Calculate Circle Area");
        Console.WriteLine("2 - Check Weight Discount");
        Console.Write("Enter choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius > 0)
            {
                double area = 3.14159 * radius * radius;
                Console.WriteLine("Area: " + area);
            }
            else
            {
                Console.WriteLine("Invalid radius");
            }
        }
        else if (choice == 2)
        {
            Console.Write("Enter weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 100)
            {
                double newWeight = weight - 5;
                Console.WriteLine("New weight: " + newWeight);
            }
            else
            {
                Console.WriteLine("Weight is normal");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }

        Console.ReadKey();
    }
}
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
//Create an array holding the numbers 10, 20, 30. Print each number on a new line by accessing their indexes
// directly (index 0, index 1, and index 2).
// Expected Output: 10 20 30

        int[] numbers = {10, 20, 30};

        for (int i= 0; i<=2; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine();

        string[] names = {"John", "Luke", "Peter", "Mark"};

        Console.WriteLine(names[3]);

        Console.WriteLine();

        int[] numbers2 = {1,2,3,4,5};
        
        Console.WriteLine("The Total sum is " + numbers2.Sum());
        // or using forloop:
        int summing = 0;
        for (int i=0; i<=4; i++)
        {
             summing += numbers2[i];
        }
        Console.WriteLine("Total sum is " + summing);

    }
}
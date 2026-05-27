using System;

public class Program
{
    public static void Main()
    {
        //1
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        //2
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

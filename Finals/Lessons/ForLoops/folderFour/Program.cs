using System;

public class ForLoops1
{

    public void ShowLoops()
    {
        //1
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();



        for (int row = 0; row < 7; row++)
        {
            // spaces
            for (int s = 0; s < 6 - row; s++)
            {
                Console.Write(" ");
            }

            // stars
            for (int star = 0; star < (row * 2) + 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
public class ForLoops2
{
    public void ShowLoops()
    {
        int items = 3;
        for (int i = 1; i <= 3; i++)
        {

            Console.WriteLine($"Test {i}.");
            if (i == 3)
            {
                Console.WriteLine("Essay: What is the purpose of Life?");
            }
            else
            {
                for (int j = 1; j <= items; j++)
                {

                    Console.WriteLine($"Question #{j}:");

                }
            }
            items++;

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
public class Program
{

    public static void Main()
    {
        ForLoops1 fLoop1 = new ForLoops1();
        ForLoops2 fLoop2 = new ForLoops2();
        fLoop1.ShowLoops();
        fLoop2.ShowLoops();
    }
}

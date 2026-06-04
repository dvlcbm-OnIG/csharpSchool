using System;
using System.Collections.Generic; //this is required for using a List

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==========================");
        Console.WriteLine("==      For Loops      ==");
        Console.WriteLine("==========================");
        //1
        Console.WriteLine("------- 1 -------");
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Liftoff!");


        //2
        Console.WriteLine("------- 2 -------");
        for (int i = 2; i <= 10; i += 2)
        {
            Console.Write(i + " ");
        }

        //3
        Console.WriteLine();
        Console.WriteLine("------- 3 -------");
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write(input + " ");
        }
        //4
        Console.WriteLine();
        Console.WriteLine("------- 4 -------");
        for (int i = 3; i <= 15; i += 3)
        {
            Console.WriteLine(i);
        }

        //5
        Console.WriteLine("------- 5 -------");
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            sum += i;
        }
        Console.WriteLine("The total sum is " + sum);

        //6
        Console.WriteLine("------- 6 -------");
        string[] Colors = { "Red", "Blue", "Green" };
        Console.WriteLine(Colors[1]);

        //7
        Console.WriteLine("------- 7 -------");
        int[] numbers = { 7, 14, 21, 28 };
        Console.WriteLine(numbers.Length);

        //8
        Console.WriteLine("------- 8 -------");
        int[] scores = { 85, 90, 75 };
        scores[0] = 95;
        Console.WriteLine(scores[0]);

        //9
        Console.WriteLine("------- 9 -------");
        string[] namess = { "Alice", "Bob", "Charlie", "David" };
        Console.WriteLine(namess[3]);

        //10
        Console.WriteLine("------- 10 -------");
        int[] numberss = { 10, 20, 30 };
        Console.WriteLine(numberss[0]);
        Console.WriteLine(numberss[1]);
        Console.WriteLine(numberss[2]);

        Console.WriteLine("or using a forloop:");

        for (int i = 0; i < numberss.Length; i++)
        {
            Console.WriteLine(numberss[i]);
        }

        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine("==      Foreach      ==");
        Console.WriteLine("==========================");


        //1
        Console.WriteLine("------- 1 -------");
        List<string> squadMembers = new List<string>()
        {
            "ProGamer", "ShadowHunter", "DragonSlayer"
        };

        foreach (string name in squadMembers)
        {
            Console.WriteLine("Online: " + name);
        }

        //2
        Console.WriteLine("------- 2 -------");
        List<double> fuelLevels = new List<double>();
        fuelLevels.Add(45.5);
        fuelLevels.Add(12.0);
        fuelLevels.Add(98.2);

        foreach (double level in fuelLevels)
        {
            Console.WriteLine("fuel percentage: " + level);
        }
        Console.WriteLine("reading recorded: " + fuelLevels.Count);

        //3
        Console.WriteLine("------- 3 -------");
        List<bool> isAvailable = new List<bool>()
        {
          true, false, true, true
        };

        foreach (bool avail in isAvailable)
        {
            if (avail == true)
            {
                Console.WriteLine("Item is ready to ship");
            }
            else
            {
                Console.WriteLine("Item is out of stock");
            }
        }

        //4
        Console.WriteLine("------- 4 -------");
        int[] dailyTemps = { 28, 30, 25, 22, 31 };

        foreach (int temp in dailyTemps)
        {
            Console.WriteLine($"Today's temperature is {temp}*C");
        }
        Console.WriteLine($"Days recorded: {dailyTemps.Length}");

        //5
        Console.WriteLine("------- 5 -------");
        List<char> vowels = new List<char>()
        {
          'A', 'E', 'I', 'O', 'U'
        };

        foreach (char letter in vowels)
        {
            Console.Write(letter + " ");
        }
    }
}
/*
Output: 

==========================
==      For Loops      ==
==========================
------- 1 -------
5
4
3
2
1
Liftoff!
------- 2 -------
2 4 6 8 10 
------- 3 -------
Enter a word: hello
hello hello hello hello 
------- 4 -------
3
6
9
12
15
------- 5 -------
The total sum is 15
------- 6 -------
Blue
------- 7 -------
4
------- 8 -------
95
------- 9 -------
David
------- 10 -------
10
20
30
or using a forloop:
10
20
30

==========================
==      Foreach      ==
==========================
------- 1 -------
Online: ProGamer
Online: ShadowHunter
Online: DragonSlayer
------- 2 -------
fuel percentage: 45.5
fuel percentage: 12
fuel percentage: 98.2
reading recorded: 3
------- 3 -------
Item is ready to ship
Item is out of stock
Item is ready to ship
Item is ready to ship
------- 4 -------
Today's temperature is 28*C
Today's temperature is 30*C
Today's temperature is 25*C
Today's temperature is 22*C
Today's temperature is 31*C
Days recorded: 5
------- 5 -------
A E I O U 

*/
//Note:  use Length for array, and Count for list

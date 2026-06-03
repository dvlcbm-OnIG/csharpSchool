using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //1
        Console.WriteLine("------- 1 -------");
      for (int i =5; i>=1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Liftoff!");


      //2
      Console.WriteLine("------- 2 -------");
      for (int i = 2; i<=10; i+=2)
        {
            Console.Write(i + " ");
        }

       //3
       Console.WriteLine();
       Console.WriteLine("------- 3 -------");
       Console.Write("Enter a word: ");
       string input = Console.ReadLine();

       for(int i= 1; i<=4; i++)
        {
            Console.Write(input + " ");
        }
        //4
        Console.WriteLine();
        Console.WriteLine("------- 4 -------");
        for (int i = 3; i<=15; i += 3)
        {
            Console.WriteLine(i);
        }

        //5
        Console.WriteLine("------- 5 -------");
        int sum = 0;
        for (int i = 1; i<=5; i++)
        {
            sum +=i;
        }
        Console.WriteLine("The total sum is 15");

    }
}
/*
Output: 

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
Enter a word: Hello
Hello Hello Hello Hello 
------- 4 -------
3
6
9
12
15
------- 5 -------
The total sum is 15

*/

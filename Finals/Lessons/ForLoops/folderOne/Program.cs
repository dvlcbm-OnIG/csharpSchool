using System;
<<<<<<< HEAD
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] names = {"john", "luke", "peter"};
        
        List<char> Vowels = new List<char>()
        {
            'A', 'E', 'I', 'O', 'U'
        };


        // foreach(string hsa in names)
        // {
        //     Console.WriteLine(hsa);
        // }

        foreach(char letter in Vowels)
        {
            Console.Write(letter + " ");
        }

    }
}
=======

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Input a number to be multiplied from 1-100: ");
        int userIn = Convert.ToInt32(Console.ReadLine());
        
        for(int i =1; i<=100; i++){
            
            int ans = userIn * i;
            Console.WriteLine($"{userIn} x {i} = {ans}");
        };
    }
}
>>>>>>> e50b6b31ba40dab1a39ca424e27f21d4a5f8eeac

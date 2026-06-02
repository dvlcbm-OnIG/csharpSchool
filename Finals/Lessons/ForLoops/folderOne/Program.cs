using System;
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
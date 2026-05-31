using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //1 Strings
        List<string> names = new List<string>()
        {
            "John", "Jacob", "Joseph", "Peter"
        };
        foreach (string name in names){
            Console.WriteLine(name);
        };
        
        //2 Integers
        List<int> numbers = new List<int>()
        {
            10, 20, 30, 40
        };
        foreach (int number in numbers){
            Console.WriteLine(number);
        };
        
        
        
        //3 Boolean
        List<bool> isStudent = new List<bool>()
        {
            true, false, false, true
        };
        foreach (bool stdnt in isStudent){
            Console.WriteLine(stdnt);
        };
        
        
        
        
        
        
    }
}

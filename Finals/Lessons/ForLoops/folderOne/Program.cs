using System;
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

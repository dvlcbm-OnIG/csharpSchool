string[] cars = {"Volvo", "BMW", "Ford"};
// Or more explicitly:
int[] age = new int[] { 20, 25, 30 }; 



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     //1  The countdown
     Console.WriteLine("-----1------");
     for (int i = 5; i>0; i--){
         Console.WriteLine(i);
     }
     Console.WriteLine("Liftoff!");
     
     //2 even numbers jump
     Console.WriteLine("-----2------");
     for(int j = 2; j<=10; j++){
         if (j % 2 == 0){
             Console.Write(j + " ");
         }
     }
     Console.WriteLine();
     
     //3 repeat message
     Console.WriteLine("-----3------");
     Console.WriteLine("Enter a word: ");
     string word = Console.ReadLine();
     
    //4
    Console.WriteLine("-----4------");
    }
}

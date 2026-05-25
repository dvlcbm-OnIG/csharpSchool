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
     for(int i = 2; i<=10; i++){
         if (i % 2 == 0){
             Console.Write(i + " ");
         }
     }
     Console.WriteLine();
     
     //3 repeat message
     Console.WriteLine("-----3------");
     Console.Write("Enter a word: ");
     string word = Console.ReadLine();
     
     for(int i=1; i<=4; i++){
         Console.Write(word + " ");
     }
     Console.WriteLine();
     
    //4 multiplication table of 3
    Console.WriteLine("-----4------");
    int number1 = 3;
    for (int i = 1; i<=5; i++){
        int multi = number1 * i;
        Console.WriteLine(multi);
    }
    //5 total sum
    Console.WriteLine("-----5------");
    
    
    
    //6 fav colors
    Console.WriteLine("-----6------");
    string[] colors = {"Red","Blue","Green"};
    Console.WriteLine(colors[1]);
    
    Console.WriteLine("-----7------");
    //7 lucky numbers
    int[] numbers1 = new int[]{7,14,21,28};
    Console.WriteLine(numbers1.Length);
    
    
    
     Console.WriteLine("-----8------");
    int[] scores = new int[]{85,90,75};
    scores[0] = 95;
    Console.WriteLine(scores[0]);
    
    
    
    
    }
}

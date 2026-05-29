using System;
using System.Collections.Generic; //for list

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //1
        Console.WriteLine("--------1--------");
       List<string> squadMembers = new List<string>(){
           "ProGamer",
           "ShadowHunter",
           "DragonSlayer"
       };
       foreach (string Name in squadMembers){
           Console.WriteLine($"Online: {Name}");
       };
       //2
       Console.WriteLine("--------2--------");
       List<double> fuelLevels =  new List<double>();
           fuelLevels.Add(45.5);
           fuelLevels.Add(12.0);
           fuelLevels.Add(98.2);
       
       foreach (double percent in fuelLevels){
           Console.WriteLine($"Fuel Percentage: {percent}%");
       };
       Console.WriteLine($"total numbers of reading: {fuelLevels.Count}");
       
       //3
       Console.WriteLine("--------3--------");
       List<bool> isAvailable = new List<bool>(){
           true,
           false,
           true,
           true
       };
       foreach (bool item  in isAvailable){
           if(item == true){
               Console.WriteLine("Item is reaady to ship.");
           }else{
               Console.WriteLine("Item is out of stock.");
           }
       };
       //4
       Console.WriteLine("--------4--------");
       int[] dailyTemps = {28, 30, 25, 22, 31};
       foreach(int temp in dailyTemps){
           Console.WriteLine($"Today's temperature is {temp}*C");
       };
       Console.WriteLine($"Days recorded: {dailyTemps.Length}");
       
       //5
       Console.WriteLine("--------5--------");
       List<char> vowels = new List<char>(){
           'A',
           'E',
           'I',
           'O',
           'U'
       };
       /*List is better than array because list helps you organize the data and also you can put it a label like  Name: "speed". it helps you loop through generic collection*/
       foreach (char letter in vowels){
           Console.WriteLine(letter);
       };
            
    }
}
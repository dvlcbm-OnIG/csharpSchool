using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Number 1
        Console.Write("enter total area: ");
        double totalArea = Convert.ToDouble(Console.ReadLine());
        double basePrice = 1000;
        double finalPrice = basePrice;
        
        if(totalArea > 500){
        finalPrice -= basePrice * 0.15;
        }
        Console.WriteLine($"Final price: ${finalPrice}");
        
        
        //NUmber 2
        Console.Write("enter temp: ");
        float temp = Convert.ToSingle(Console.ReadLine());
        
        string result;
        if(temp > 38.0){
            result = "High Fever";
        }else if(temp >= 37.5){
            result = "Warning";
        }else{
            result = "Normal";
        }
        
         Console.WriteLine($"Result: {result}");
         
         //number 3
         Console.Write("enter score: ");
         int score = Convert.ToInt32(Console.ReadLine());
        
        char grade;
        if(score >=90){
          grade = 'A';  
        }else if(score >=80){
          grade = 'B';  
        }else{
          grade = 'F';  
        }
        Console.WriteLine($"Grade: {grade}");
        
        //number4
        Console.Write("enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        int unitPrice;
        if(quantity >=50){
            unitPrice = 8;
        }else{
            unitPrice = 10;
        }
        int totalCost = quantity *unitPrice ;
        Console.WriteLine($"Total:{totalCost:C}");
        
        //number 5
        Console.Write("enter password: ");
        string password = Console.ReadLine();
        
        string status;
        if(password.Length < 8){
            status = "Weak";
        }else{
            status = "Strong";
        }
        Console.WriteLine($"Status: {status}");
        
        //number 6
        Console.Write("enter hours: ");
        decimal hours = Convert.ToDecimal(Console.ReadLine());
        
        decimal pay;
        if(hours >8){
            pay = (8 * 15)+ ((hours -8) *20);
        }else{
            pay = hours * 15;
        }
          Console.WriteLine($"total pay: {pay:C}");
        
        
        //number 7
        Console.Write("water temp: ");
        float waterTemp = Convert.ToSingle(Console.ReadLine());
        
        string state;
        if(waterTemp <=0){
          state = "solid";
        }else if(waterTemp >= 100){
            state = "Gas";
        }else{
            state ="Liquid";
        }
        Console.WriteLine($"State: {state}");
        
        
        //number 8
        Console.Write("are you a student (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());
        
        int discount;
        if(isStudent){
            discount = 20;
        }else{
            discount = 0;
        }
        Console.WriteLine($"Discount: {discount}");
        
        //number 9
         Console.Write("'S'= Start', 'E'= Exit:");
         char choice = Convert.ToChar(Console.ReadLine());
         
         string output;
         if(choice =='S'){
             output = "Start";
         }else if(choice =='E' ){
             output = "Exit";
         }else{
             output = "Invalid";
         }
          Console.WriteLine($"{output}");
          
          //number10
         Console.Write("enter speed: ");
         int speed = Convert.ToInt32(Console.ReadLine());
         
         int fine;
         if(speed >100){
             fine = 500;
         }else if(speed >65){
             fine = 100;
         }else{
             fine = 0;
         }
          Console.WriteLine($"Fine amount: {fine}");

          Console.ReadKey();
    }
}
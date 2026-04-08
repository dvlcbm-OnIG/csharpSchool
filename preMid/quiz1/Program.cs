Item #1 the gamer profile

using System;

class GamerProfile
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your fist name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your current level: ");
        int level = Convert.ToInt32(Console.ReadLine());
 
        int nextLevel = level + 1;

        Console.WriteLine($"Profile Created: {lastName}, {firstName}. Current Rank: {level}. Get ready for level {nextLevel}!");



        Console.ReadKey();
    }
}






Item #2 the tech support ticket

using System;

class TechSupportTicket
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your device name: ");
        string device = Console.ReadLine();

        Console.Write("Enter the brand of your device: ");
        string brand = Console.ReadLine();

        Console.Write("Enter the model year of your device: ");
        int year = Convert.ToInt32(Console.ReadLine());

        string ticketID = brand + year;

        Console.WriteLine($"Hello! Your {brand} {device} has been logged. Your support ID is {ticketID} -HELP.");


        Console.ReadKey();
    }
}




Item #3 the smart savings tracker

using System;

class SmartSavingsTracker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Username: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your current balance: ");
        int currentBalance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly goal: ");
        int monthlyGoal = Convert.ToInt32(Console.ReadLine());

        int futureBalance = currentBalance + monthlyGoal;

        Console.WriteLine($"User: {userName} Current Balance: ${currentBalance}. If you hit your goal, your new balance will be ${futureBalance}!");


        Console.ReadKey();
    }
}


Item #4 the superhero identity

using System;

class SuperHeroIdentity
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your real name: ");
        string realName = Console.ReadLine();

        Console.Write("Enter your hero name: ");
        string heroName = Console.ReadLine();

        Console.Write("Enter your power level (1-100): ");
        int powerLevel = Convert.ToInt32(Console.ReadLine());

        int energyUnits = powerLevel * 10;

        Console.WriteLine($"Identity Confirmed: {realName} is secretly {heroName}! Energy Output: {energyUnits} Tera-watts.");


        Console.ReadKey();
    }
}



Item #5 the rpg inventory check

using System;

class RpgInventoryCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter character name: ");
        string characterName = Console.ReadLine();

        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter curent item amount: ");
        int currentAmount = Convert.ToInt32(Console.ReadLine());

        int newAmount = currentAmount + 5;

        Console.WriteLine($"{characterName}, you found a chest! You now have {newAmount} {itemName}. Keep going!");

        Console.ReadKey();
    }
}



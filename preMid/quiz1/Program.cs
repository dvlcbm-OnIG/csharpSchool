using System;

class Program
{
    static void GamerProfile()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your current level: ");
        int level = Convert.ToInt32(Console.ReadLine());

        int nextLevel = level + 1;

        Console.WriteLine($"Profile Created: {lastName}, {firstName}. Current Rank: {level}. Get ready for level {nextLevel}!");
    }

    static void TechSupportTicket()
    {
        Console.Write("Enter your device name: ");
        string device = Console.ReadLine();

        Console.Write("Enter the brand of your device: ");
        string brand = Console.ReadLine();

        Console.Write("Enter the model year of your device: ");
        int year = Convert.ToInt32(Console.ReadLine());

        string ticketID = brand + year;

        Console.WriteLine($"Hello! Your {brand} {device} has been logged. Your support ID is {ticketID} -HELP.");
    }

    static void SmartSavingsTracker()
    {
        Console.Write("Enter Username: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your current balance: ");
        int currentBalance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly goal: ");
        int monthlyGoal = Convert.ToInt32(Console.ReadLine());

        int futureBalance = currentBalance + monthlyGoal;

        Console.WriteLine($"User: {userName} Current Balance: ${currentBalance}. If you hit your goal, your new balance will be ${futureBalance}!");
    }

    static void SuperHeroIdentity()
    {
        Console.Write("Enter your real name: ");
        string realName = Console.ReadLine();

        Console.Write("Enter your hero name: ");
        string heroName = Console.ReadLine();

        Console.Write("Enter your power level (1-100): ");
        int powerLevel = Convert.ToInt32(Console.ReadLine());

        int energyUnits = powerLevel * 10;

        Console.WriteLine($"Identity Confirmed: {realName} is secretly {heroName}! Energy Output: {energyUnits} Tera-watts.");
    }

    static void RpgInventoryCheck()
    {
        Console.Write("Enter character name: ");
        string characterName = Console.ReadLine();

        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter current item amount: ");
        int currentAmount = Convert.ToInt32(Console.ReadLine());

        int newAmount = currentAmount + 5;

        Console.WriteLine($"{characterName}, you found a chest! You now have {newAmount} {itemName}. Keep going!");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1 - Gamer Profile");
        Console.WriteLine("2 - Tech Support Ticket");
        Console.WriteLine("3 - Smart Savings Tracker");
        Console.WriteLine("4 - Superhero Identity");
        Console.WriteLine("5 - RPG Inventory Check");
        Console.Write("Enter choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                GamerProfile();
                break;
            case 2:
                TechSupportTicket();
                break;
            case 3:
                SmartSavingsTracker();
                break;
            case 4:
                SuperHeroIdentity();
                break;
            case 5:
                RpgInventoryCheck();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadKey();
    }
}
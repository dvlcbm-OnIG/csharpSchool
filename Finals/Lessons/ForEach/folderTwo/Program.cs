using System;

public class chapter2
{
    public void Show1()
    {
        //1
        List<int> playerScores = new List<int>() { 67 };
        playerScores.Add(120);
        playerScores.Add(85);
        playerScores.Add(200);
        playerScores.Add(45);
        playerScores.Add(160);

        foreach (int score in playerScores)
        {
            if (score >= 100)
            {
                Console.WriteLine($"Qualified Score: {score}");
            }
            else
            {
                Console.WriteLine($"Needs Improvement: {score}");
            }
        }
    }
    public void Show2()
    {
        List<string> studentNames = new List<string>()
        {
            "Kyle", "Anne", "Mark", "Luna"
        };

        List<bool> attendance = new List<bool>()
        {
            true, false, true, true
        };

        int index = 0;
        int presentCount = 0;

        foreach (string student in studentNames)
        {
            if (attendance[index] == true)
            {
                Console.WriteLine(student + " is Present");
                presentCount++;
            }
            else
            {
                Console.WriteLine(student + " is Absent");
            }

            index++;
        }

        Console.WriteLine("Total Present: " + presentCount);
    }
}
public class Program
{
    public static void Main()
    {
        //1
        chapter2 c2 = new chapter2();
        //c2.Show1();
        c2.Show2();

        Console.ReadKey();
    }
}
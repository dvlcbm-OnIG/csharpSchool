

using System;

public class AgeBracket
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value >=1 && value <= 10)
            {
                _age = value;
            }
        }
    }
    
    
}

public class Program
{
    public static void Main()
    {
        AgeBracket AgeB = new AgeBracket();

        AgeB.Age = ;

        Console.WriteLine(AgeB.Age);

        Console.ReadKey();
    } 
}

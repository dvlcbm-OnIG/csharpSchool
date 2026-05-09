using System;

//1
public class AgeBracket
{
    public int _age;
    
    public int AgePro
    {
        get { return _age; }
        set
        {
            if (value > 0 && value < 11)
            {
                _age = value;
            }
        }
    }
}

//2
public class CharUserName
{
    private string _username;
    public string UserN
    {
         get { return _username; }
         set
        {
            if (value.Length == 10)
            {
                _username = value;
            }
        }
    }
}

//4
public class HiddenPin
{
    private string _pin;
    public string Pin
    {
        get { return "****"; }
        set
        {
            if ( value.Length == 4)
            {
                _pin = value;
            }
        }
    }
}

//5
public class PriceFloor
{
    private int _price;
    public int Price
    {
        get { return _price; }
        set { _price = Math.Max(10, value); }  // returns the larger value between two numbers.
    }
}

//6
public class ScoreIncre
{
    private int _score;

    public int Score
    {
        get { return _score; }
        set
        {
            if (value == _score + 10)
            {
                _score = value;
            }
        }
    }
}

//7
public class IdMask
{
    private string _id;
    public string ID
    {
        get { return _id.Substring(6);  }
        set
        {
            if (value.Length == 10)
            {
                _id = value;
            }
        }
    }
}

//8
public class LevelClock
{
    private int _level;
    public int Level
    {
        get { return _level; }
        set
        {
            if (value >= _level)
            {
                _level = value;
            }
        }
    }
}

//9
public class PercentClamp
{
    private int _percent;
    public int Percent
    {
        get { return _percent; }
        set
        {
            if (value < 0)
            {
                _percent = 0;
            }else if (value > 100){
                _percent = 100;
            }else{ _percent = value; }
        }
    }
}

public class TenChar
{
    private string _username;
    public string UserN
    {
        get { return _username; }
        set
        {
            if (value.Length == 10)
            {
                _username = value; 
            }
           
        }
    }
}

public class Program
{
    public static void Main()
    {
        //1
        AgeBracket Ag = new AgeBracket();// can only put value if constructor exist.
        Ag.AgePro = 10;
        Ag.AgePro = 7; // overides the 10

        Console.WriteLine($"1. {Ag.AgePro}");

        //2
        CharUserName CharUN =  new CharUserName();
        CharUN.UserN = "1234567890";

        Console.WriteLine($"2. {CharUN.UserN}");

        //4
        HiddenPin hPin = new HiddenPin();
        hPin.Pin = "1234";
        Console.WriteLine($"4. {hPin.Pin}");
     

        //5
        PriceFloor pFloor = new PriceFloor();
        pFloor.Price = 9; //returns 10 coz of mathmax
        Console.WriteLine($"5. {pFloor.Price}");


        //6
        ScoreIncre sIn = new ScoreIncre();
        sIn.Score = 10;

        Console.WriteLine($"6. {sIn.Score}");

        //7
        IdMask idM = new IdMask();
        idM.ID = "1234567890";

        Console.WriteLine($"7. {idM.ID}");

        //8
        LevelClock lClock = new LevelClock();
        lClock.Level = 1; // first value assigned
        lClock.Level = 2; // new value
        lClock.Level = 1; // still 2. Can't decrease
        lClock.Level = 3; // new value

        Console.WriteLine($"8. {lClock.Level}");
        //9
        PercentClamp pClamp = new PercentClamp();
        pClamp.Percent = -1;

        Console.WriteLine($"9. {pClamp.Percent}");

        //10
        TenChar tChar = new TenChar();
        tChar.UserN = "1234567890";

        Console.WriteLine($"10. {tChar.UserN}");
        Console.ReadKey();
    }
}
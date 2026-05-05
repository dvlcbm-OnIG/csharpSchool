using System;

// 1
public class AgeBracket
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 1 && value <= 10)
            {
                _age = value;
            }
        }
    }
}

// 2. 
public class Username
{
    private string _username;

    public string Name
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

// 3. 
public class StockLimit
{
    private int _stock;

    public int Stock
    {
        get { return _stock; }
        set
        {
            if (value <= 10)
            {
                _stock = value;
            }
        }
    }
}

// 4. 
public class Pin
{
    private string _pin;

    public string Code
    {
        get { return "****"; }
        set
        {
            if (value.Length == 4)
            {
                _pin = value;
            }
        }
    }
}

// 5. 
public class Price
{
    private int _price;

    public int Value
    {
        get { return _price; }
        set
        {
            _price = Math.Max(10, value);
        }
    }
}

// 6. 
public class Score
{
    private int _score;

    public int Value
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

// 7. 
public class IDMask
{
    private string _id;

    public string ID
    {
        get
        {
            if (_id != null && _id.Length == 10)
            {
                return _id.Substring(6);
            }
            return null;
        }
        set
        {
            if (value.Length == 10)
            {
                _id = value;
            }
        }
    }
}

// 8. 
public class Level
{
    private int _level;
    public int Value
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

// 9.
public class Percent
{
    private int _percent;
    public int Value
    {
        get { return _percent; }
        set
        {
            if (value < 0) _percent = 0;
            else if (value > 100) _percent = 100;
            else _percent = value;
        }
    }
}

// 10. 
public class UsernameFixed
{
    private string _username;
    public string Name
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
    public static void Main(string[] args)
    {
        AgeBracket a = new AgeBracket();
        a.Age = 5;

        Username u = new Username();
        u.Name = "1234567890";

        StockLimit s = new StockLimit();
        s.Stock = 15;

        Pin p = new Pin();
        p.Code = "1234";

        Price pr = new Price();
        pr.Value = 5;

        Score sc = new Score();
        sc.Value = 10;

        IDMask id = new IDMask();
        id.ID = "1234567890";

        Level lv = new Level();
        lv.Value = 1;
        lv.Value = 0;

        Percent pc = new Percent();
        pc.Value = 150;

        Console.WriteLine($"1. {a.Age}");
        Console.WriteLine($"2. {u.Name}");
        Console.WriteLine($"3. {s.Stock}");
        Console.WriteLine($"4. {p.Code}");
        Console.WriteLine($"5. {pr.Value}");
        Console.WriteLine($"6. {sc.Value}");
        Console.WriteLine($"7. {id.ID}");
        Console.WriteLine($"8. {lv.Value}");
        Console.WriteLine($"9. {pc.Value}");
      

        Console.ReadKey();
    }
}


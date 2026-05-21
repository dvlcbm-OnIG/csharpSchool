using System;
//1
public class SecuritySystem
{
    private string _status;
    public string PowerStatus
    {
        get { return _status;  }
        set
        {
            if (value == "On")
            {
                _status = value;
            } else
            {
                _status = "Off";
            }
        }
    }
    public void ShowStatus()
    {
        Console.WriteLine($"1. Status: {PowerStatus}");
    }
}
//2
public class Store
{
    private int _discount;
    public int Discount
    {
        get { return _discount;  }
        set
        {
            if (value > 50)
            {
                _discount = 50;
            }else
            {
                _discount = value;
            }
        }
    }
    public void ShowDiscount()
    {
        Console.WriteLine($"2. Discount: {Discount}");
    }
}
//3
public class Gym
{
    private int _level;
    public int Level
    {
        get { return _level; }
        set
        {
            if (value > 3)
            {
                _level = 3;
            }else if (value < 1)
            {
                _level = 1;
            }else
            {
                _level = value;
            }
        }
    }
    public void ShowLevel()
    {
        Console.WriteLine($"3. Level: {Level}");
    }
}
//4
public class Tracker
{
    private int _steps;
    public Tracker(int steps)
    {
        Steps = steps;
    }
    public int Steps
    {
        get { return _steps; }
        set
        {
            if (value > _steps)
            {
                _steps = value;
            }
        }
    }
    public void ShowSteps()
    {
        Console.WriteLine($"4. Steps: {Steps}");
    }
}
//5
public class Safe
{
    private int _pin;
    public Safe(int pin)
    {
        Pin = pin;
    }
    public int Pin
    {
        get { return _pin;  }
        set { _pin = value; }
    }
    public void ShowPin()
    {
        Console.WriteLine($"5. Pin: {Pin}");
    }
}
public class Program
{
    public static void Main()
    {
        SecuritySystem secSy = new SecuritySystem();
        Store store = new Store();
        Gym gym = new Gym();
        Tracker track = new Tracker(10);
        Safe safe = new Safe(10);


        secSy.PowerStatus = "On";
        store.Discount = 51;
        gym.Level = 4;
       


        secSy.ShowStatus();
        store.ShowDiscount();
        gym.ShowLevel();
        track.ShowSteps();
        safe.ShowPin();

        Console.ReadKey();
    }
}
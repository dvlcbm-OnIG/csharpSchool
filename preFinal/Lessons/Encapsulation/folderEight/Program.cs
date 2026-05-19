//exam prefinal
using System;

//1
public class SecuritySystem
{
    private string _status;

    public string PowerStatus
    {
        get { return _status; }
        set
        {
            if (value == "On")
            {
                _status = value;
            }
            else
            {
                _status = "Off";
            }
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine("System Status: " + _status);
    }
}

//2
public class Store
{
    private int _discount;

    public int Discount
    {
        get { return _discount; }
        set
        {
            if (value > 50)
            {
                _discount = 50;
            }
            else
            {
                _discount = value;
            }
        }
    }

    public void ShowDiscount()
    {
        Console.WriteLine("Discount: " + _discount);
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
            }
            else if (value < 1)
            {
                _level = 1;
            }
            else
            {
                _level = value;
            }
        }
    }

    public void ShowLevel()
    {
        Console.WriteLine("Membership Level: " + _level);
    }
}

//4
public class Tracker
{
    private int _steps;

    //constructor
    public Tracker(int steps)
    {
        _steps = steps;
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
        Console.WriteLine("Steps: " + _steps);
    }
}

//5
public class Safe
{
    private int _pin;

    //constructor
    public Safe(int pin)
    {
        _pin = pin;
    }

    public int Pin
    {
        get { return _pin; }
        set
        {
            if (value == 1234)
            {
                _pin = value;
            }
        }
    }

    public void ShowPin()
    {
        Console.WriteLine("PIN: " + _pin);
    }
}

public class Program
{
    public static void Main()
    {
        //1
        SecuritySystem sec = new SecuritySystem();

        sec.PowerStatus = "On";
        sec.ShowStatus();

        sec.PowerStatus = "Open";
        sec.ShowStatus();

        //2
        Store st = new Store();

        st.Discount = 70;
        st.ShowDiscount();

        //3
        Gym gym = new Gym();

        gym.Level = 5;
        gym.ShowLevel();

        gym.Level = 0;
        gym.ShowLevel();

        //4
        Tracker tr = new Tracker(100);

        tr.Steps = 120;
        tr.ShowSteps();

        tr.Steps = 90;
        tr.ShowSteps();

        //5
        Safe sf = new Safe(1111);

        sf.Pin = 1234;
        sf.ShowPin();

        sf.Pin = 9999;
        sf.ShowPin();

        Console.ReadKey();
    }
}
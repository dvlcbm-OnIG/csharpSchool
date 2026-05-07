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
        Console.ReadKey();
    }
}
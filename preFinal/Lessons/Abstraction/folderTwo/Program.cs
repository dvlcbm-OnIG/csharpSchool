using System;

// abstract class = a base template for related payment types.
abstract class Payment
{
    // abstract method = every child class must write its own version.
    public abstract void Pay(double amount);

    // shared method = ready-made code that all child classes can use.
    public void PrintReceipt(double amount)
    {
        Console.WriteLine("Paid: " + amount);
    }
}

// GCash version of Payment.
class GCashPayment : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine("Paying using GCash...");
    }
}

// Credit Card version of Payment.
class CreditCardPayment : Payment
{
    public override void Pay(double amount)
    {
        Console.WriteLine("Paying using Credit Card...");
    }
}

class Program
{
    static void Main()
    {
        // This variable can hold any class that inherits Payment.
        Payment payment;

        // Use GCashPayment first.
        payment = new GCashPayment(); 
        payment.Pay(100);
        payment.PrintReceipt(100);

        // Then switch to CreditCardPayment.
        payment = new CreditCardPayment();
        payment.Pay(200);
        payment.PrintReceipt(200);

        // Output:
        // Paying using GCash...
        // Paid: 100
        // Paying using Credit Card...
        // Paid: 200
    }
}
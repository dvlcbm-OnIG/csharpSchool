using System;

// "abstract" = cannot create this directly
abstract class Animal
{
    // abstract method = a rule that child classes must follow.
    public abstract void MakeSound();

    // normal method = already has its own code and can be used right away.
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

// Dog inherits Animal
class Dog : Animal
{
    // override means this method replaces the parent class version with Dog's own sound.
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Bark");
    }
}

class Program
{
    static void Main()
    {
        // Animal a = new Animal(); - not allowed

        Dog myDog = new Dog(); // - allowed

        myDog.MakeSound();
        myDog.Sleep();


        //output:   Dog says: Bark
        //          Animal is sleeping



        // Abstraction (simple explanation):
        // Role:
        // - It gives a common blueprint (Animal) for related classes.
        // - It tells child classes what they MUST do (MakeSound).
        // - It keeps main code cleaner because we focus on "what" to do, not full details first.
        //
        // Characteristics:
        // - Abstract class cannot be instantiated directly.
        // - Abstract methods have no body in the parent class.
        // - Child classes must override abstract methods.
        // - Abstract class can still have normal methods with ready code (like Sleep).
    }
}
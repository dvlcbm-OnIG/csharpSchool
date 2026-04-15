using System;

class Animal
{
    
    public virtual void MakeSound()// virtual means child classes can change this method.
    {
        // Base version used if a child class does not replace it.
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    
    public override void MakeSound()// override means Dog gives its own version of MakeSound.
    {
        // Dog's own sound.
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    
    public override void MakeSound()// override means Cat gives its own version of MakeSound.
    {
        // Cat's own sound.
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        // These are Animal variables, but they point to Dog and Cat objects.
        Animal a1 = new Dog();
        Animal a2 = new Cat();


        //a1 = new Cat(); this overrides the Dog object

        // Calls the Dog version.
        a1.MakeSound();

        // Calls the Cat version.
        a2.MakeSound();

        Console.ReadKey();
    }
}
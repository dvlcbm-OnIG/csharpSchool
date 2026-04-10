using System;

class Animal
{
    // virtual means child classes can change this method.
    public virtual void MakeSound()
    {
        // Base version used if a child class does not replace it.
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // override means Dog gives its own version of MakeSound.
    public override void MakeSound()
    {
        // Dog's own sound.
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    // override means Cat gives its own version of MakeSound.
    public override void MakeSound()
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

        // Calls the Dog version.
        a1.MakeSound();

        // Calls the Cat version.
        a2.MakeSound();
    }
}
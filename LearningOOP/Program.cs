using System;

// Abstract class
abstract class Animal
{
    // Abstract method (no implementation here)
    public abstract void Sound();

    // Non-abstract method (optional)
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog AWWSSS.");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat Meowss.");
    }
}

// Main program
class Program
{
    public static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.Sound();  // Output: Dog AWWSSS.
        animal.Eat();    // Output: This animal eats food.

        animal = new Cat();
        animal.Sound();  // Output: Cat Meowss.
        animal.Eat();    // Output: This animal eats food.
    }
}

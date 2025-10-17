using System;
using System.Runtime.CompilerServices;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sounds");
    }
    
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog AWWSSS.");
    }
}
class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat Meowss.");
    }
}
class Program
{
    public static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.Sound();

        animal = new Cat();
        animal.Sound();
    }
   

}
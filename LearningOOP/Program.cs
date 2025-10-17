using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Dog inherits from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks!");
    }
}

class Cat : Animal
{
    public void Cuttie()
    {
        Console.WriteLine("The cat Cuttie");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();   
        myDog.Bark();
        Cat cat = new Cat();
        cat.Eat();
        cat.Cuttie();
    }
}

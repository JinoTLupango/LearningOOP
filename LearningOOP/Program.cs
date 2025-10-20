using System;

namespace SimpleCalculator 
{
    class Program
    {
        static void Main(string[] args)
        {
          Calculator calc = new Calculator();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Simple Calculator ===");
                Console.WriteLine("[1] Addition (+)");
                Console.WriteLine("[2] Subtraction (-)");
                Console.WriteLine("[3} Multiplacation (*)");
                Console.WriteLine("[4] Division (/)");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("Choose an operation");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    running = false;
                    Console.WriteLine("Exiting calculator.... Goodbye!");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool valid = true;

                switch (choice)
                {
                    case "1":
                        result = calc.Add(num1, num2);
                        break;

                    case "2":
                        result = calc.Subtract(num1, num2);
                        break;

                    case "3":
                        result = calc.Multiply(num1, num2);
                        break;

                    case "4":
                        result = calc.Divide(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        valid = false;
                        break;
                }

                if (valid)
                {
                    Console.WriteLine($"\nResult: {result}");
                }

                Console.WriteLine("\nPress any key to continue.....");
                Console.ReadKey();
            }
        }
    }
}

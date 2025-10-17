using LearningOOP;
using System;
using System.Collections.Generic;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            Console.Write("How many users do you want to add? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Enter details for User #{i + 1} ---");

                int id = GetIntInput("Enter ID: ");
                string name = GetStringInput("Enter Name: ");
                int age = GetIntInput("Enter Age: ");
                string course = GetStringInput("Enter Course: ");
                string address = GetStringInput("Enter Address: ");
                string email = GetStringInput("Enter Email: ");

                // Create and add user
                users.Add(new User(id, name, age, course, address, email));
            }

            Console.WriteLine("\n========== ALL USERS ==========");
            foreach (var user in users)
            {
                user.DisplayInfo();
            }

            Console.ReadLine();
        }

        // Helper methods for cleaner validation
        static int GetIntInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Please enter a valid number!");
            }
        }

        static string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}

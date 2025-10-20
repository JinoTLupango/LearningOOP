using LearningOOP;
using System;
using System.Collections.Generic;

namespace LearningOOP
{
    class Program
    {
        static List<User> users = new List<User>();
        static readonly List<string> validCourses = new List<string>
        {
            "BSIT", "BSN", "BSMT", "BSE", "BSA", "BSC", "BSTM"
        };

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("==== USER MANAGEMENT SYSTEM ===");
                Console.WriteLine("[1] Add User");
                Console.WriteLine("[2] View All Users");
                Console.WriteLine("[3] Search User");
                Console.WriteLine("[4] Update User");
                Console.WriteLine("[5] Delete User");
                Console.WriteLine("[0] Exit");
                Console.Write("Select an Option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddUser();
                        break;

                    case "2":
                        ViewAllUsers();
                        break;

                    case "3":
                        SearchUser();
                        break;

                    case "4":
                        UpdateUser();
                        break;

                    case "5":
                        DeleteUser();
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Exiting System..... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try Again!");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                }
            }
        }

        // Add new user
        static void AddUser()
        {
            Console.Clear();
            Console.WriteLine("==== ADD NEW USER ====");
            int id = GetIntInput("Enter ID: ");
            string name = GetStringInput("Enter Name: ");
            int age = GetIntInput("Enter Age: ");
            string course = GetCourseInput(); // <-- uses new method for validation
            string address = GetStringInput("Enter Address: ");
            string email = GetStringInput("Enter Email: ");

            users.Add(new User(id, name, age, course, address, email));
            Console.WriteLine("\nUser Successfully Added!");
        }

        // View all users
        static void ViewAllUsers()
        {
            Console.Clear();
            Console.WriteLine("==== ALL USERS ====");

            if (users.Count == 0)
            {
                Console.WriteLine("No users found!");
                return;
            }

            foreach (var user in users)
            {
                user.DisplayInfo();
                Console.WriteLine("-----------------------");
            }
        }

        // Search user by ID or Name
        static void SearchUser()
        {
            Console.Clear();
            Console.WriteLine("==== SEARCH USER ====");
            string search = GetStringInput("Enter ID or NAME: ");

            bool found = false;
            foreach (var user in users)
            {
                if (user.Id.ToString() == search || user.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    user.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No user found with that ID or Name.");
            }
        }

        // Update user info
        static void UpdateUser()
        {
            Console.Clear();
            Console.WriteLine("==== UPDATE USER ====");

            int id = GetIntInput("Enter ID to update: ");
            var user = users.Find(u => u.Id == id);

            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }

            string name = GetStringInput("Enter new Name: ");
            int age = GetIntInput("Enter new Age: ");
            string course = GetCourseInput();
            string address = GetStringInput("Enter new Address: ");
            string email = GetStringInput("Enter new Email: ");

            user.UpdateInfo(name, age, course, address, email);
            Console.WriteLine("\nUser updated successfully!");
        }

        // Delete user by ID
        static void DeleteUser()
        {
            Console.Clear();
            Console.WriteLine("==== DELETE USER ====");

            int id = GetIntInput("Enter ID to delete: ");
            var user = users.Find(x => x.Id == id);

            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User Deleted successfully!");
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }

        // Integer input validation
        static int GetIntInput(string prompt)
        {
            int value;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    if (prompt.ToLower().Contains("age") && value >= 100)
                    {
                        Console.WriteLine("Invalid Age! Age must be less than 100.\n");
                        continue;
                    }
                    return value;
                }

                Console.WriteLine("Invalid input! Enter a valid number.\n");
            }
        }

        // String input
        static string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Course validation method
        static string GetCourseInput()
        {
            while (true)
            {
                Console.Write("Enter Course (BSIT, BSN, BSMT, BSE, BSA, BSC, BSTM): ");
                string course = Console.ReadLine().ToUpper();

                if (validCourses.Contains(course))
                    return course;

                Console.WriteLine("Invalid Course! Please choose from the list above.\n");
            }
        }
    }
}

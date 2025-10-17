using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    public class User
    {
        //  Encapsulation: Private fields
        private int Id { get; set; }
        private string Name { get; set; }
        private int Age {  get; set; }
        private string Course { get; set; }
        private string Address { get; set; }
        private string Email { get; set; }

        //  Constructor
        public User(int id, string name, int age,string course, string address, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Course = course;
            this.Address = address;
            this.Email = email;
        }

        // Method to display user info
        public void DisplayInfo()
        {
            Console.WriteLine("===== USER INFORMATION =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}

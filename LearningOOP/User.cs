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
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age {  get; private set; }
        public string Course { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
            
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

        public void UpdateInfo(string name,int age, string course,string address,string email)
        {
            Name= name;
            Age= age;
            Course= course;
            Address= address;
            Email= email;


        }
    }
}

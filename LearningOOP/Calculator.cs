using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SimpleCalculator
{
    // Calculator Class (Encapsulation and Methods)
    public class Calculator
    {
        // Addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Division (with error check)
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return double.NaN; // Not a Number
            }
            return a / b;
        }
    }
}


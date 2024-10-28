using System;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the 'MathOperations' class
            var mathOps = new MathOperations();

            // Call the 'PerformOperation' method, passing in two numbers
            mathOps.PerformOperation(3, 8);

            // Call the 'PerformOperation' method again, specifying the parameters by name
            mathOps.PerformOperation(num1: 45, num2: 43);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

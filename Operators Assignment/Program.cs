using System;

namespace Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties.
            var employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate the second Employee object and assign values to its properties.
            var employee2 = new Employee
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Compare the two Employee objects using the overloaded '==' operator.
            Console.WriteLine(employee1 == employee2
                ? "Both employees are considered equal based on their Id."
                : "The employees are not equal based on their Id.");

            // Compare the two Employee objects using the overloaded '!=' operator.
            Console.WriteLine(employee1 != employee2
                ? "The employees are considered different based on their Id."
                : "Both employees are considered the same based on their Id.");

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}

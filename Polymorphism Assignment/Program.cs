using System;

namespace Polymorphism_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and assign values to its properties.
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Use polymorphism to create an object of type IQuittable.
            IQuittable quittableEmployee = employee;

            // Call the Quit() method on the IQuittable object.
            quittableEmployee.Quit();

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}

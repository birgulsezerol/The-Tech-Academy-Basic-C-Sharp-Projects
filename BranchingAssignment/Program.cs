using System;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package weight is greater than 50
            if (weight > 50)
            {
                // Display error message and end the program if the package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt user for the package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt user for the package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt user for the package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the sum of the dimensions is greater than 50
            if (width + height + length > 50)
            {
                // Display error message and end the program if the package is too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the volume of the package
            double volume = width * height * length;

            // Calculate the quote by multiplying the volume by the weight and dividing by 100
            double quote = (volume * weight) / 100;

            // Display the quote as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
    }
}

using System;

namespace Polymorphism_Assignment
{
    public class Employee : IQuittable
    {
        // Properties for the Employee class.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit() method from the IQuittable interface.
        public void Quit()
        {
            // This method simulates an employee quitting their job by displaying a message.
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }

        // Overload the '==' operator to compare Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to compare Employee objects by their Id.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override the Equals method to ensure consistency with '==' operator.
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override the GetHashCode method as a best practice when overriding Equals.
        public override int GetHashCode() => Id.GetHashCode();
    }
}

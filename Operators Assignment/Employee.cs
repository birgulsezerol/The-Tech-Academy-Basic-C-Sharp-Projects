namespace Operators_Assignment
{
    public class Employee
    {
        // Properties for the Employee class.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true.
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one of the objects is null, return false.
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Ids of the two Employee objects.
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to compare Employee objects by their Id.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the '==' operator to determine inequality.
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

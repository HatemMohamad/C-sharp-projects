using System; // 📦 Pulling in essential .NET features like Console

// 🧑‍💼 Employee class bundled right inside this single file — clean and compact!
public class Employee
{
    // 🆔 Employee's unique identifier
    public int Id { get; set; }

    // 🎭 Employee's first name
    public string FirstName { get; set; }

    // 🏷️ Employee's last name
    public string LastName { get; set; }

    // 🔍 Overloading the '==' operator so we can compare Employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // 🪞 If both variables point to the exact same object, they're equal
        if (ReferenceEquals(emp1, emp2))
            return true;

        // 🚫 If one is null but the other isn't, they can't be equal
        if (((object)emp1 == null) || ((object)emp2 == null))
            return false;

        // 🎯 Comparison strictly based on the Id value
        return emp1.Id == emp2.Id;
    }

    // 🔄 Required paired overload for the '!=' operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // 🙅 Opposite of whatever '==' determines
        return !(emp1 == emp2);
    }

    // 🧹 Overriding Equals() to stay consistent with operator overloading
    public override bool Equals(object obj)
    {
        Employee other = obj as Employee;
        if (other == null)
            return false;

        return this.Id == other.Id;
    }

    // 🧮 Overriding GetHashCode() because Equals() was overridden
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    // 🚀 Entry point of this console application
    static void Main(string[] args)
    {
        // 👨‍💼 Creating Employee #1 with a unique ID and name values
        Employee emp1 = new Employee
        {
            Id = 101,          // 🆔 Assign ID
            FirstName = "Hatem", // 🎭 Assign first name
            LastName = "Mohammed"    // 🏷️ Assign last name
        };

        // 👩‍💼 Creating Employee #2 with a different ID (so we expect inequality)
        Employee emp2 = new Employee
        {
            Id = 102,            // 🆔 Different ID for comparison
            FirstName = "Paul",  // 🎭 First name
            LastName = "Smith"   // 🏷️ Last name
        };

        // 🔎 Using our overloaded '==' operator to compare Employees
        bool areEqual = emp1 == emp2;

        // 📣 Showing result of equality check
        Console.WriteLine($"Are emp1 and emp2 equal (==)? {areEqual}");

        // 🔎 Using our overloaded '!=' operator to check inequality
        bool areNotEqual = emp1 != emp2;

        // 📣 Showing inequality result
        Console.WriteLine($"Are emp1 and emp2 NOT equal (!=)? {areNotEqual}");

        // 📴 Keeping the console open so the output stays visible
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

using System; // 📦 Bringing in the System namespace for console functionality

// 🧩 Defining the IQuittable interface — a contract that guarantees a Quit() method exists
public interface IQuittable
{
    // 🚪 A void method named Quit() — any class implementing this interface MUST provide its own version
    void Quit();
}

// 🧑‍💼 Employee class — inherits both object functionality AND the IQuittable interface contract
public class Employee : IQuittable
{
    // 🆔 Employee ID property
    public int Id { get; set; }

    // 🎭 Employee first name
    public string FirstName { get; set; }

    // 🏷️ Employee last name
    public string LastName { get; set; }

    // 🎤 Implementing the Quit() method from IQuittable — our own custom behavior!
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} says: \"I quit!\" 👋"); 
        // 💬 The employee loudly declares their resignation — dramatic flair optional!
    }
}

class Program
{
    // 🚀 Entry point of the console application
    static void Main(string[] args)
    {
        // 👨‍💼 Creating an Employee object like usual
        Employee employee = new Employee
        {
            Id = 202,
            FirstName = "Sam",
            LastName = "Thompson"
        };

        // 🎭 POLYMORPHISM MAGIC: 
        //    We're storing the Employee object in an IQuittable reference
        //    because Employee *implements* the IQuittable interface.
        IQuittable quitter = employee;  

        // 🎬 Calling the Quit() method using the interface reference
        //    This is classic polymorphism — same method call, different object implementations.
        quitter.Quit();

        // 📴 Pausing the console so the user can admire the output
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

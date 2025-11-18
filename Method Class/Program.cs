using System;   // 🌐 Bringing in the System namespace so we can use Console and other core features

namespace MathDemoApp   // 🏷️ Creating a namespace to keep our code nicely organized
{
    // 🧮 This class will hold our custom method that works with two integers
    class MathOperations
    {
        // ➡️ A method that takes two integers and performs operations on them.
        //    It returns nothing because the keyword 'void' says so.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // ✏️ Performing a simple math operation (doubling the first integer)
            int result = firstNumber * 2;

            // 📣 Displaying the result of the operation
            Console.WriteLine($"The result of doubling the first number ({firstNumber}) is: {result}");

            // 👀 Displaying the second integer exactly as instructed
            Console.WriteLine($"The second number you passed in is: {secondNumber}");
        }
    }

    // 🚀 Program entry point — this is where everything begins when the app runs
    class Program
    {
        static void Main(string[] args)
        {
            // 🏗️ Creating (instantiating) our MathOperations class so we can use its methods
            MathOperations mathOps = new MathOperations();

            // 🎯 Calling the method and just passing in two numbers normally
            mathOps.ProcessNumbers(5, 10);

            // 🎯 Calling the method AGAIN, but this time specifying the parameters by name
            mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 3);

            // ⏹️ Keeping the console window open so the output stays visible
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

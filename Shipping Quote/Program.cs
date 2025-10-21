using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            double weight;
            bool isWeightValid = double.TryParse(Console.ReadLine(), out weight);

            if (!isWeightValid)
            {
                Console.WriteLine("Invalid input for weight. Exiting program.");
                return;
            }

            // Check if package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt for package width
            Console.WriteLine("Please enter the package width:");
            double width;
            bool isWidthValid = double.TryParse(Console.ReadLine(), out width);

            if (!isWidthValid)
            {
                Console.WriteLine("Invalid input for width. Exiting program.");
                return;
            }

            // Prompt for package height
            Console.WriteLine("Please enter the package height:");
            double height;
            bool isHeightValid = double.TryParse(Console.ReadLine(), out height);

            if (!isHeightValid)
            {
                Console.WriteLine("Invalid input for height. Exiting program.");
                return;
            }

            // Prompt for package length
            Console.WriteLine("Please enter the package length:");
            double length;
            bool isLengthValid = double.TryParse(Console.ReadLine(), out length);

            if (!isLengthValid)
            {
                Console.WriteLine("Invalid input for length. Exiting program.");
                return;
            }

            // Check if the sum of dimensions is too large
            double dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the result formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}

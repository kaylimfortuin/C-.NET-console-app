/*Write a C# program that uses a while loop to count the digits of a user-input
number.*/
namespace DigitCounter // Define a namespace for the program
{
    class Program // Define the Program class
    {
        static void Main(string[] args) // Main method, entry point of the program
        {
            Console.Write("Enter a number: "); // Prompt the user to enter a number
            string input = Console.ReadLine(); // Read the user input as a string
            int count = 0; // Initialize the digit count to 0

            while (input.Length > count) // Loop until the count equals the length of the input
            {
                count++; // Increment the count
            }

            Console.WriteLine($"The number of digits is: {count}"); // Print the digit count
        }
    }
}


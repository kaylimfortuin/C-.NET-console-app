using System; // Import the System namespace for console input and output

namespace ValidateInput // Define a namespace for the program
{
    class Program // Define the Program class
    {
        static void Main(string[] args) // Main method, entry point of the program
        {
            int number; // Declare a variable to store the user input
            Console.Write("Enter a number between 1 and 100: "); // Prompt the user to enter a number

            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100) // Validate the input
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100."); // Inform the user of invalid input
                Console.Write("Enter a number between 1 and 100: "); // Prompt the user again
            }

            Console.WriteLine($"You entered a valid number: {number}"); // Print the valid input
        }
    }
}
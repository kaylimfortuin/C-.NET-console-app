using System; // Import the System namespace for console input and output

namespace PrintPositiveNumbers // Define a namespace for the program
{
    class Program // Define the Program class
    {
        static void Main(string[] args) // Main method, entry point of the program
        {
            int[] numbers = { 10, 20, -5, 30, 40 }; // Initialize an array of integers
            int index = 0; // Initialize the index variable to 0

            while (index < numbers.Length) // Loop while the index is less than the array length
            {
                if (numbers[index] < 0) // Check if the current number is negative
                {
                    break; // Exit the loop if a negative number is found
                }

                Console.WriteLine(numbers[index]); // Print the current number to the console
                index++; // Increment the index
            }
        }
    }
}
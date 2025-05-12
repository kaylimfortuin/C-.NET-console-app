using System; // Import the System namespace for console input and output

namespace NestedWhileLoop // Define a namespace for the program
{
    class Program // Define the Program class
    {
        static void Main(string[] args) // Main method, entry point of the program
        {
            int i = 1; // Initialize the outer loop counter to 1

            while (i <= 5) // Outer loop runs while i is less than or equal to 5
            {
                int j = 1; // Initialize the inner loop counter to 1

                while (j <= 5) // Inner loop runs while j is less than or equal to 5
                {
                    Console.Write((i * j).ToString().PadLeft(4)); // Print the product of i and j, padded to 4 spaces
                    j++; // Increment the inner loop counter
                }

                Console.WriteLine(); // Print a newline after each row of the table
                i++; // Increment the outer loop counter
            }
        }
    }
}
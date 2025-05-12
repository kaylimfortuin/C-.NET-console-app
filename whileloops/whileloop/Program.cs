namespace WhileLoops // Define a namespace for the program
{
    namespace whileloop // Define a nested namespace for the program
    {
        using System; // Import the System namespace for console input and output

        class Program // Define the Program class
        {
            static void Main(string[] args) // Main method, entry point of the program
            {
                int number = 1; // Initialize the number variable to 1

                while (number <= 10) // Loop while the number is less than or equal to 10
                {
                    Console.WriteLine(number); // Print the current number to the console
                    number++; // Increment the number
                }

            }


        }
    }
}


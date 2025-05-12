using System; // Imports the System namespace for basic functionality like Console

class Program // Defines a class named Program
{
    static void Main(string[] args) // Main method, the entry point of the program
    {
        int counter = 1; // Initializes a variable 'counter' to 1

        do // Starts the do...while loop, executes the block at least once
        {
            Console.WriteLine($"Counter value is: {counter}"); // Prints the current value of counter
            counter++; // Increments the counter by 1
        } while (counter <= 5); // Condition: loop continues as long as counter is less than or equal to 5

        Console.WriteLine("Loop finished!"); // Prints a message after the loop ends
    }
}
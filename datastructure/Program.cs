using System;

class Program
{
    static void Main(string[] args)
    {
        // Define variables
        int myInt = 42;
        float myFloat = 3.14f;
        string myString = "Hello, World!";
        bool myBool = true;

        // Perform addition
        float result = myInt + myFloat;

        // Display variables in the terminal
        Console.WriteLine("Integer: " + myInt);
        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("String: " + myString);
        Console.WriteLine("Boolean: " + myBool);
        Console.WriteLine("Addition Result (Int + Float): " + result);
    }
}
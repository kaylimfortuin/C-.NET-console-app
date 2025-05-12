using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create an array
        List<int> numbers = new List<int> { 1, 2, 3, 4 };
        Console.WriteLine("Original Array: " + string.Join(", ", numbers));

        // Step 2: Append an element
        numbers.Add(5);
        Console.WriteLine("After Append: " + string.Join(", ", numbers));

        // Step 3: Remove an element
        numbers.Remove(3); // Removes the first occurrence of the value 3
        Console.WriteLine("After Removing 3: " + string.Join(", ", numbers));

        // Step 4: Extend the array (add multiple elements)
        numbers.AddRange(new List<int> { 6, 7, 8 });
        Console.WriteLine("After Extending: " + string.Join(", ", numbers));
    }
}
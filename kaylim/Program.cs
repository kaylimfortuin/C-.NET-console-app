using System;
using System.Collections.Generic;
class Program
{
static void Main()
{
// Create a list of numbers
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
// Calculate the average using standard methods
int total = 0;
foreach (int num in numbers)
{
total += num;
}
double average = (double)total / numbers.Count;
Console.WriteLine($"The average is: {average}");
}
}
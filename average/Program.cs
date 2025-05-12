using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
static void Main()
{
// Create a list of numbers
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
// Calculate the average using LINQ
double average = numbers.Average();
Console.WriteLine($"The average is: {average}");
}
}2
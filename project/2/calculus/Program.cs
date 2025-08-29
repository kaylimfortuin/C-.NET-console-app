using System;

namespace calusus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // a) Define the time t as 2 seconds
                double t = 2.0;

                // Validate that time is not negative
                if (t < 0)
                {
                    System.Console.WriteLine("Time cannot be negative.");
                }

                // b) Calculate the velocity using the formula v = 3 × t²
                // Velocity formula: v(t) = 3t² meters per second
                double velocity = 3 * Math.Pow(t, 2);

                // c) Calculate the position using the formula s = t³
                // Position formula: s(t) = t³ meters (assuming initial position s(0) = 0)
                double position = Math.Pow(t, 3);

                // d) Output the results 
                System.Console.WriteLine($"At t={t} seconds, the velocity is {velocity}m/s and its position is {position}meters.");
            }
            catch (ArgumentException ex)
            {
                // f) Error handling for invalid input (negative time)
                System.Console.WriteLine($"Error: {ex}");
            }
            catch (System.Exception ex)
            {
                // General error handling
                System.Console.WriteLine($"Error: {ex}");
            }
        }
    }
}